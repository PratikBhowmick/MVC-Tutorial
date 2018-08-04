using MVC_EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_EFCodeFirst.Content
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> Blogs {get; set;}
        public DbSet<Post> Posts { get; set; }
    }
}