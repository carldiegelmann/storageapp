using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Domain
{
    public class Customer
    {
        public String CustomerID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }

        public String IBAN { get; set; }
        public bool IsLocked { get; set; }

        public List<Payment> Payments { get; set; }

    }
}
