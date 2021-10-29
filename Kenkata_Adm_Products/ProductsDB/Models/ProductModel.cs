using System;
using System.Collections.Generic;
using System.Linq;

namespace Kenkata_Adm_Products.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CustomerCategory { get; set; }
        public string Season { get; set; }
        public string Cathegory { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string InStock { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string CreateDate { get; set; }
    }
}
