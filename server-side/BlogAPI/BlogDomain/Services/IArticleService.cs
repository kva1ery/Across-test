using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogDomain.Models;

namespace BlogDomain.Services
{
    public interface IArticleService
    {
        IEnumerable<Article> GetArticles();

        Article GetArticleById(int id);

        Article SaveArticle(Article article);

        void DeleteArticle(int id);
    }
}
