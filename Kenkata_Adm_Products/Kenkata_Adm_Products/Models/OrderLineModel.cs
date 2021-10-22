using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products.Models
{
    public class OrderLineModel
    {
        public int OrderLineNr { get; set; }
        public int OrderId { get; set; }
        public int ProdId { get; set; }
        public int Quantity { get; set; }
        public decimal APrice { get; set; }
        public DateTime Created { get; set; }

    }
}
