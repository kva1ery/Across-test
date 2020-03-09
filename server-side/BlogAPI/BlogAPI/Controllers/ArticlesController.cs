using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using BlogDomain.Models;
using BlogDomain.Services;

namespace BlogAPI.Controllers
{
    public class ArticlesController : ApiController
    {
        private readonly IArticleService _articleService;

        public ArticlesController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IEnumerable<Article> GetArticles() => _articleService.GetArticles();

        public Article GetArticle(int id) => _articleService.GetArticleById(id);

        public void PostArticle([FromBody] Article article) => _articleService.SaveArticle(article);
        
        public void Delete(int id)
        {
            _articleService.DeleteArticle(id);
        }
    }
}
