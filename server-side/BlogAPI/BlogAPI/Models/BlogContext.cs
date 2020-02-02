using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogAPI.Models
{
    public class BlogContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}