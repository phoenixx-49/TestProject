using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Sorting
    {
        public Sorting() { }

        public struct PurchaseInfo
        {
            public DateTime PurchaseDate { get; set; }
            public string ClientName { get; set; }
            public decimal CheckAmount { get; set; }
            public string PurchaseImage { get; set; }
        }
        /// <summary>
        /// Сортирует список покупок по заданным параметрам
        /// </summary>
        /// <param name="indexFieldSort">Индекс поля сортировки (По какому полю сортируем).</param>
        /// <param name="indexFieldOrderliness">Индекс порядка сортировки (0 - сортировка по возрастанию, 1 - сортировка по убыванию)</param>
        /// <returns>Коллекция отсортированная заданным образом</returns>
        public IEnumerable<PurchaseInfo> Sort(int indexFieldSort, int indexFieldOrderliness)
        {
            List<Purchase> purchaseCollection = null;
            if (indexFieldOrderliness == 0)
            {
                if (indexFieldSort == 0)
                {
                    using (MarketContext context = new MarketContext())
                    {
                        purchaseCollection = context.Purchases.OrderBy(x => x.PurchaseDate).ToList();
                    }
                }
                else
                {
                    using (MarketContext context = new MarketContext())
                    {
                        purchaseCollection = context.Purchases.OrderBy(x => x.Price).ToList();
                    }
                }
            }
            else
            {
                if (indexFieldSort == 0)
                {
                    using (MarketContext context = new MarketContext())
                    {
                        purchaseCollection = context.Purchases.OrderByDescending(x => x.PurchaseDate).ToList();
                    }
                }
                else
                {
                    using (MarketContext context = new MarketContext())
                    {
                        purchaseCollection = context.Purchases.OrderByDescending(x => x.Price).ToList();
                    }
                }
            }

            List<PurchaseInfo> purchaseList = new List<PurchaseInfo>();

            foreach (Purchase purchase in  purchaseCollection)
            {
                PurchaseInfo info = new PurchaseInfo();
                info.PurchaseDate = purchase.PurchaseDate;

                using(MarketContext context = new MarketContext())
                {
                    info.ClientName = context.Clients.SingleOrDefault(x => x.Id == purchase.ClientId).FullName();
                }
                
                info.CheckAmount = purchase.Price;
                info.PurchaseImage = purchase.PathPurchaseImage;
                purchaseList.Add(info);
            }

            return purchaseList;      
        }
    }
}
