using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products.Models
{
    public class ProductDBModel
    {
        //[Key]
        public string id { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string CustomerCathegory { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Season { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Cathegory { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Brand { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "string")]
        public string Size { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public string InStock { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public string Price { get; set; }

        [Required]
        [Column(TypeName = "object")]
        public string Image { get; set; }
        public DateTime Created { get; set; }
    }
}
