using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageApp.Domain
{
    public class ArticleImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageTitle { get; set; }
        public byte [] ImageData { get; set; }
        public string ImageType { get; set; }  // JPG, PNG, ect.

    }
}
