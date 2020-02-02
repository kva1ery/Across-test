using System.Collections.Generic;
using System.Data.Entity;
using System.Web.Http;
using BlogAPI.Models;

namespace BlogAPI.Controllers
{
    public class ArticlesController : ApiController
    {

        private BlogContext context = new BlogContext();

        public IEnumerable<Article> GetArticles()
        {
            return context.Articles;
        }

        public Article GetArticle(int id)
        {
            var article = context.Articles.Find(id);
            return article;
        }

        public void PostArticle([FromBody]Article article)
        {
            context.Articles.Add(article);
            context.SaveChanges();
        }

        public void PutArticle(int id, [FromBody]Article article)
        {
            if (id == article.Id)
            {
                context.Entry(article).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void Delete(int id)
        {
            var article = context.Articles.Find(id);
            if (article != null)
            {
                context.Articles.Remove(article);
                context.SaveChanges();
            }

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
