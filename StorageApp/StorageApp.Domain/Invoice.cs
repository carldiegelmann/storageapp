using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Domain
{
    public class Invoice
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public DateTime Created { get; set; }
        public Payment Payment { get; set; }
    }
}
