using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_application_6
{
    public static class Virtual_Database
    {
        public static List<Clients> clients { get; set; }

        static Virtual_Database()
        {
            clients = new List<Clients>();
        }
    }
}
