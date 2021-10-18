using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsDB.Models
{
    class ProductModel
    {
        public string id { get; set; }
        public string CustomerCathegory { get; set; }
        public string Season { get; set; }
        public string Cathegory { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string InStock { get; set; }
        public string Price { get; set; }
    }
}
