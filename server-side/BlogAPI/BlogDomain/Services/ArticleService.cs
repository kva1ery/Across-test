using System;
using System.Collections.Generic;
using System.Linq;
using BlogDomain.Models;
using BlogDomain.Repositories;

namespace BlogDomain.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IEnumerable<Article> GetArticles()
        {
            return _articleRepository.GetAll().OrderBy(a => a.PubDate).ToList();
        }

        public Article GetArticleById(int id)
        {
            return _articleRepository.GetAll().FirstOrDefault(a => a.Id == id);
        }

        public Article SaveArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException("article");
            }

            if (article.Id == null)
            {
                return _articleRepository.Add(article);
            }
            else
            {
                _articleRepository.Update(article);
                return article;
            }
        }

        public void DeleteArticle(int id)
        {
            var article = GetArticleById(id);
            if (article != null)
            {
                _articleRepository.Delete(article);
            }
        }
    }
}