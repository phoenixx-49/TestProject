using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class MarketContext : DbContext
    {
        public MarketContext() : base("DbConnection")
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<InformationAboutClient> InformationAboutClients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}
