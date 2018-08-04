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

        public string Quantity { get; set; }

    }
}