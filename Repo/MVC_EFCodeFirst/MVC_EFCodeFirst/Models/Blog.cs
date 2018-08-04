using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace MVC_EFCodeFirst.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }
        
    }
}