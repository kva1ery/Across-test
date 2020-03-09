using System.Data.Entity;
using BlogDomain.Models;

namespace BlogApiEF
{
    public class BlogContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}