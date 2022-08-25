using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Domain
{
    public class OrderLine
    {
        public int Id { get; set; }
        
        // Bestellmenge
        public int Quantity { get; set; }
        public Order Order  { get; set; }
        public Article Article { get; set; }

    }
}
