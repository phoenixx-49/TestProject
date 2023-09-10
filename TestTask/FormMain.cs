using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            bool isEmpty = TbxLastname.Text.Trim() == "" || TbxFirstname.Text.Trim() == "";
            if (isEmpty)
            {
                MessageBox.Show("Проверьте правильность введённых данных и повторите попытку!", "Ошибка исходных данных", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (MarketContext context = new MarketContext())
            {
                Client client = new Client()
                {
                    Lastname = TbxLastname.Text.Trim(),
                    Firstname = TbxFirstname.Text.Trim(),
                    Patronymic = TbxPatronymic.Text.Trim()
                };

                context.Clients.Add(client);
                context.SaveChanges();

                DgbClients.Rows.Clear();

                foreach (Client item in context.Clients)
                {
                    DgbClients.Rows.Add(item.Id, item.FullName());
                }
            }

            TbxLastname.Clear();
            TbxFirstname.Clear();
            TbxPatronymic.Clear();
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            using (MarketContext context = new MarketContext())
            {
                DgbClients.Rows.Clear();
                foreach (Client client in context.Clients)
                {
                    DgbClients.Rows.Add(client.Id, client.FullName());
                }
            }
        }

        private void BtnAddAdvantedInfo_Click(object sender, EventArgs e)
        {
            if (DgbClients.RowCount <= 0)
            {
                MessageBox.Show("Добавьте нового клиента и повторите попытку!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            FormAdvancedInfo formAdvantedInfo = new FormAdvancedInfo(int.Parse(DgbClients.Rows[DgbClients.CurrentRow.Index].Cells[0].Value.ToString()));
            formAdvantedInfo.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (DgbClients.RowCount <= 0)
            {
                MessageBox.Show("Нет клиента для редактирования!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormEdit formEdit = new FormEdit(int.Parse(DgbClients.Rows[DgbClients.CurrentRow.Index].Cells[0].Value.ToString()));
            formEdit.ShowDialog();

            DgbClients.Rows.Clear();
            UpdateDgbClients();
        }
        /// <summary>
        /// Обновляет данные в списке клиентов
        /// </summary>
        private void UpdateDgbClients()
        {
            using (MarketContext context = new MarketContext())
            {
                foreach (Client client in context.Clients)
                {
                    DgbClients.Rows.Add(client.Id, client.FullName());
                }
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (DgbClients.RowCount == 0)
            {
                MessageBox.Show("Нет клиентов для удаления!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int deleteClientId = int.Parse(DgbClients.Rows[DgbClients.CurrentRow.Index].Cells[0].Value.ToString());

            DialogResult res = MessageBox.Show("Вы действительно хотите удалить выбранного клиента?", "Внимание! Необратимая операция.", MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation);
            
            if (res == DialogResult.No)
            {
                return;
            }

            using (MarketContext context = new MarketContext())
            {
                var aboutClientInfo = context.InformationAboutClients.Where(x => x.ClientId == deleteClientId);

                context.InformationAboutClients.RemoveRange(aboutClientInfo);
                //context.SaveChanges();

                var purchasesClients = context.Purchases.Where(x => x.ClientId == deleteClientId);
                context.Purchases.RemoveRange(purchasesClients);
                //context.SaveChanges();

                var deletedClient = context.Clients.Single(x => x.Id == deleteClientId);
                context.Clients.Remove(deletedClient);

                context.SaveChanges();
            }

            DgbClients.Rows.Clear();
            UpdateDgbClients();
            MessageBox.Show("Успешно удалено!", "Результат операции.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAddPurchase_Click(object sender, EventArgs e)
        {
            int clientsCount = 0;
            using (MarketContext context = new MarketContext())
            {
                clientsCount = context.Clients.Count();
            }

            if (clientsCount == 0)
            {
                MessageBox.Show("Отсутствуют клиенты для оформления покупок!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            FormAddPurchase formAddPurchase = new FormAddPurchase();
            formAddPurchase.ShowDialog();
        }

        private void BtnListPurchase_Click(object sender, EventArgs e)
        {
            FormPurchases formPurchases = new FormPurchases();
            this.Hide();
            formPurchases.ShowDialog();
            this.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            BtnGet_Click(sender, e);
        }

        private void BtnCloseApplication_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
