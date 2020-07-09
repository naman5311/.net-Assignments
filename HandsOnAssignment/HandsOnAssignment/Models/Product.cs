using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HandsOnAssignment.Models
{
    public class Product
    {   [Required(ErrorMessage ="Product Id Required")]
        public string Pid { get; set; }
        [Required(ErrorMessage = "Product Name Required")]
        public string Pname { get; set; }
        [Required(ErrorMessage = "Product Price Required")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Stock Required")]
        public int? Stock { get; set; }

    }
}
