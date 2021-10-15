using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Products_Administration.Models
{
    public class Product
    {
        public DateTime Date { get; set; }
        public int CustomerCathegory { get; set; }
        public int ProductSeason { get; set; }
        public int ProductCathegory { get; set; }
        public int ProductBrand { get; set; }
        public int ProductColor { get; set; }
        public int ProductSize { get; set; }
        public int NumberOfProducts { get; set; }
        public int ProductPrice { get; set; }
        public object ProductImage { get; set; }
    }
}
