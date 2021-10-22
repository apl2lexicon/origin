using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public int PayMethod { get; set; }
        public bool Payed { get; set; }
        public DateTime Canceled { get; set; }
        public bool Basket { get; set; }
        public DateTime Created { get; set; }
    }
}
