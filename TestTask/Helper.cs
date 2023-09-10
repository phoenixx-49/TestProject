using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public static class Helper
    {
        /// <summary>
        /// Возвращает ФИО клиента в строковом формате
        /// </summary>
        /// <param name="client">Экземпляр клиента</param>
        /// <returns>ФИО пользователя в строковом формате</returns>
        public static string FullName(this Client client)
        {
            return $"{client.Lastname} {client.Firstname} {client?.Patronymic}";
        }
        /// <summary>
        /// Проверяет, является ли строка Email адресом
        /// </summary>
        /// <param name="emailAddress">Email - адрес в строковом формате</param>
        /// <returns>Значение true или false</returns>
        public static bool IsEmail(this string emailAddress)
        {
            bool result = true;
            try
            {
                MailAddress mail = new MailAddress(emailAddress);
            }
            catch(Exception ex)
            {
                result = false;
                MessageBox.Show(ex.Message);
            }
            return result;
        }
        /// <summary>
        /// Проверяет, содержится ли в номере телефона 10 цифр
        /// </summary>
        /// <param name="phoneNumber">Номер телефона в строковом формате</param>
        /// <returns>Значение true если количество цифр в номере равно 10-ти, иначе false</returns>
        public static bool IsNumberPhone(this string phoneNumber)
        {
            int countDigit = phoneNumber.ToList().Where(x => char.IsDigit(x) == true).Count();
            return countDigit == 10;
        }

        public static bool IsMoney(this string valueMoney)
        {
            return decimal.TryParse(valueMoney, out decimal res);
        }
    }
}
