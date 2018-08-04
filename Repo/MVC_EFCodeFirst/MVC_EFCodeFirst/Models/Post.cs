using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_EFCodeFirst.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}