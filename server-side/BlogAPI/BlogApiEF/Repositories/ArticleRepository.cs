using System.Data.Entity;
using System.Linq;
using BlogDomain.Models;
using BlogDomain.Repositories;

namespace BlogApiEF.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private BlogContext _context;

        public ArticleRepository(BlogContext context)
        {
            _context = context;
        }

        public Article Add(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
            return article;
        }

        public void Update(Article article)
        {
            _context.Entry(article).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(Article article)
        {
            _context.Articles.Remove(article);
            _context.SaveChanges();
        }

        public IQueryable<Article> GetAll()
        {
            return _context.Articles;
        }
    }
}
