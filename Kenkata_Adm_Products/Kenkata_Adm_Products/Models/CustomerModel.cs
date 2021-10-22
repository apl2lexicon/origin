using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public int AreaCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string ContactInfo { get; set; }
        public DateTime Created { get; set; }
    }
}
