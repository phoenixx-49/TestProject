using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class FormAddPurchase : Form
    {
        public FormAddPurchase()
        {
            InitializeComponent();
        }

        List<int> clientsId = new List<int>();
        List<string> clientsFio = new List<string>();
        string fileNameToDataBase = string.Empty;

        private void FormAddPurchase_Load(object sender, EventArgs e)
        {
            OpenFile.FileName = string.Empty;

            using (MarketContext context = new MarketContext())
            {
                clientsId.Clear();
                clientsFio.Clear();
                foreach (var client in context.Clients)
                {
                    clientsId.Add(client.Id);
                    clientsFio.Add(client.FullName());
                }
            }

            CmbClients.Items.Clear();
            CmbClients.Items.AddRange(clientsFio.ToArray());

            CmbClients.SelectedIndex = 0;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!TbxCost.Text.Trim().IsMoney())
            {
                MessageBox.Show("Сумма введена некорректно!", "Ошибка исходных данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (OpenFile.FileName != string.Empty)
            {
                string newFileName = Guid.NewGuid().ToString();
                File.Copy(OpenFile.FileName, Application.StartupPath + "\\Images\\" + newFileName + Path.GetExtension(OpenFile.FileName));
                fileNameToDataBase = "Images\\" + newFileName + Path.GetExtension(OpenFile.FileName);// Имя файла в базе данных
            }

            using (MarketContext context = new MarketContext())
            {
                Purchase purchase = new Purchase()
                {
                    ClientId = clientsId[CmbClients.SelectedIndex],
                    PurchaseDate = DateTime.Parse(DtpPurchaseDate.Value.ToString()),
                    Price = decimal.Parse(TbxCost.Text.Trim()),
                    PathPurchaseImage = fileNameToDataBase
                };

                context.Purchases.Add(purchase);
                context.SaveChanges();
            }
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            Image purchaseImage = null;
            try
            {
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    purchaseImage = Image.FromFile(OpenFile.FileName);
                    PbxPurchasePhoto.Image = purchaseImage;
                }
            }
            catch
            {
                MessageBox.Show("Файл повреждён или не является изображением");
                PbxPurchasePhoto.Image = null;
                OpenFile.FileName = string.Empty;
                return;
            }

            if (!Directory.Exists(Application.StartupPath + "\\Images\\"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Images\\");
            }
        }
    }
}
