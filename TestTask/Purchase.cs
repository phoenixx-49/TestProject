using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Purchase
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Price { get; set; }
        public string PathPurchaseImage { get; set; }

        public virtual Client Client { get; set; }
    }
}
