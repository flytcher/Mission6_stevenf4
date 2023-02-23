using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_stevenf4.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}
