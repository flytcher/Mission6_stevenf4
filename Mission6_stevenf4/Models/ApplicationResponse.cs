﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_stevenf4.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public int categoryID { get; set; }
        [Required]
        public string title { get; set; }
        public int year { get; set; }
        public string director { get; set; }
        public string rating {get; set; }

        public Category category { get; set; }
    }
}
