using System.Linq;
using BlogDomain.Models;

namespace BlogDomain.Repositories
{
    public interface IArticleRepository
    {
        Article Add(Article article);

        void Update(Article article);

        void Delete(Article article);

        IQueryable<Article> GetAll();
    }
}
