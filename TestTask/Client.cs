using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class Client
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Patronymic { get; set; }

        public virtual ICollection<InformationAboutClient> InformationAboutClient { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}
