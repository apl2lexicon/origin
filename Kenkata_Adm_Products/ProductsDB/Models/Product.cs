using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsDB.Models
{
    class Product
    {
        public int id { get; set; }
        public int CustomerCathegory { get; set; }
        public int ProductSeason { get; set; }
        public int ProductCathegory { get; set; }
        public int ProductBrand { get; set; }
        public int ProductColor { get; set; }
        public int ProductSize { get; set; }
        public int ProductsInStock { get; set; }
        public int ProductPrice { get; set; }
    }
}
