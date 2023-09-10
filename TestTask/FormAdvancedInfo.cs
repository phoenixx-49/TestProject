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
    public partial class FormAdvancedInfo : Form
    {
        private int CurrentClientId { get; set; }

        public FormAdvancedInfo(int currentClientId)
        {
            InitializeComponent();
            CurrentClientId = currentClientId;
            DtpBirthday.Value = DateTime.Now;
        }

        private void FormAdvancedInfo_Load(object sender, EventArgs e)
        {
            //HACK: Не понятен момент с дополнительными данными клиента, так как например, эл. почт и номеров телефонов может быть несколько,
            // а вот дата рождения может быть одна. Я бы перенёс дату рождения в таблицу клиентов, а для номеров телефонов и почтовых ящиков
            // выделил бы отдельные таблицы.
            using (MarketContext context = new MarketContext())
            {
                LblFullName.Text = context.Clients.Single(c => c.Id == CurrentClientId).FullName();
            }
        }

        private void BtnAddAdvancedInfo_Click(object sender, EventArgs e)
        {
            if (!TbxEmail.Text.Trim().IsEmail())
            {
                MessageBox.Show("Адрес эл. почты некорректен!", "Ошибка ввода данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!TbxMaskPhone.Text.Trim().IsNumberPhone())
            {
                MessageBox.Show("Введённый номер телефона некорректен!!", "Ошибка ввода данных!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            using (MarketContext context = new MarketContext())
            {
                InformationAboutClient informationAbout = new InformationAboutClient()
                {
                    ClientId = CurrentClientId,
                    Email = TbxEmail.Text.Trim(),
                    Phone= TbxMaskPhone.Text.Trim(),
                    Birthday = DtpBirthday.Value.ToShortDateString()
                };

                context.InformationAboutClients.Add(informationAbout);
                context.SaveChanges();
            }

            Close();
        }
    }
}
