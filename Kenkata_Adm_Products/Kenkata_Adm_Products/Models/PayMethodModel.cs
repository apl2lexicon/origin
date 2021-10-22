using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products.Models
{
    public class PayMethodModel
    {
        public int Id { get; set; }
        public string PayMethod { get; set; }
        public DateTime Created { get; set; }
    }
}
