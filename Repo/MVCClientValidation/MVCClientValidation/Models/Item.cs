using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCClientValidation.Models
{
    public class Item
    {
        [Required]
        public string Name { get; set; }

        public string Price { get; set; }
        [Range(1, 50, ErrorMessage ="Qualtity should be between 1 and 100")]
        public string Quantity { get; set; }

    }
}