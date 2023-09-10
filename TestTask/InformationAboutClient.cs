using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    public class InformationAboutClient
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Birthday { get; set; }

        public virtual Client Client { get; set; }
    }
}
