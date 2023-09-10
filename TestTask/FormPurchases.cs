using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class FormPurchases : Form
    {
        public FormPurchases()
        {
            InitializeComponent();
        }

        private void CbxSort_CheckedChanged(object sender, EventArgs e)
        {
            CmbFieldSort.Enabled = CbxSort.Checked;
            CmbOrderliness.Enabled = CbxSort.Checked;

            if (CbxSort.Checked)
            {
                CmbFieldSort_SelectedIndexChanged(sender, e);
            }
        }

        private void FormPurchases_Load(object sender, EventArgs e)
        {
            CmbFieldSort.SelectedIndex = 0;
            CmbOrderliness.SelectedIndex = 0;
            CmbFieldSort.Enabled = false;
            CmbOrderliness.Enabled = false;

            DgbPurchases.Rows.Clear();

            FillDgbPurchase();
        }

        private void FillDgbPurchase()
        {
            using (MarketContext context = new MarketContext())
            {
                List<Purchase> purchases = context.Purchases.ToList();
                foreach (Purchase item in purchases)
                {
                    Image img = null;
                    try
                    {
                        img = Image.FromFile(Application.StartupPath + "\\" + item.PathPurchaseImage);
                    }
                    catch
                    {
                        img = Image.FromFile(Application.StartupPath + "\\defaultImage.png");
                    }

                    string clientName = item.Client.FullName();

                    DgbPurchases.Rows.Add(item.PurchaseDate.ToString("dd.MM.yyyy"), clientName, item.Price, img);
                }
            }
        }

        private void CmbFieldSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!CbxSort.Checked)
            {
                return;
            }

            Sorting sorting = new Sorting();

            var orderByCollection = sorting.Sort(CmbFieldSort.SelectedIndex, CmbOrderliness.SelectedIndex);

            DgbPurchases.Rows.Clear();

            foreach(var item in orderByCollection)
            {
                Image img = null;
                try
                {
                    img = Image.FromFile(item.PurchaseImage);
                }
                catch
                {
                    img = Image.FromFile(Application.StartupPath + "\\defaultImage.png");
                }

                DgbPurchases.Rows.Add(item.PurchaseDate.ToString("dd.MM.yyyy"), item.ClientName, item.CheckAmount, img);
            }
        }

        private void CmbOrderliness_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbFieldSort_SelectedIndexChanged(sender, e);
        }
    }
}
