using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Domain
{
    public class Article
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public String PromotionText { get; set; }
        public ArticleCategory Category { get; set; }
        public List<Part> Parts { get; set; } = new List<Part>();
        public List<ArticleImage> Images { get; set; } = new List<ArticleImage>();
        public double ActualPrice { get; set; }
        // recommended manufacturer price
        public double ManufacturerPrice { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public Supplier? Supplier { get; set; }
        public DateTime? LastChange { get; set; }
        public bool SoftDeleted { get; set; }
    }
}
