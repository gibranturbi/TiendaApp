using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TiendaApp.Models
{
    public class ProductCE
    {
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Product Price")]
        public decimal ProductPrice { get; set; }
    }
}