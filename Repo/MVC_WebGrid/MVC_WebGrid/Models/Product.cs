using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_WebGrid.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Quantity { get; set; }
    }
}