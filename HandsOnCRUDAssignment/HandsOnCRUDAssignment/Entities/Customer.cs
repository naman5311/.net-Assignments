using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnCRUDAssignment.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public string Cid { get; set; }
        [Required]
        [StringLength(40)]
        public string Cname { get; set; }
        public string EmailId { get; set; }
        public string City { get; set; }

    }
}
