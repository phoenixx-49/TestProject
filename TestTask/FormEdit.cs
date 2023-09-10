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
    public partial class FormEdit : Form
    {
        private int CurrentClientId { get; set; }
        Client currentClient = null;

        public FormEdit(int currentClientId)
        {
            InitializeComponent();
            CurrentClientId = currentClientId;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            using (MarketContext context = new MarketContext())
            {
                currentClient = context.Clients.Single(c => c.Id == CurrentClientId);
                TbxLastname.Text = currentClient?.Lastname;
                TbxFirstname.Text = currentClient?.Firstname;
                TbxPatronymic.Text = currentClient?.Patronymic;
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            bool isCorrect = TbxLastname.Text.Trim() != string.Empty && TbxFirstname.Text.Trim() != string.Empty;

            if (!isCorrect)
            {
                MessageBox.Show("Проверьте правильность вводимых данных и повторите попытку!", "Ошибка исходных данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (MarketContext context = new MarketContext())
            {
                var updatedClient = context.Clients.Single(c => c.Id == CurrentClientId);
                updatedClient.Lastname = TbxLastname.Text.Trim();
                updatedClient.Firstname = TbxFirstname.Text.Trim();
                updatedClient.Patronymic = TbxPatronymic.Text.Trim();

                context.SaveChanges();
            };
            this.Close();
        }
    }
}
