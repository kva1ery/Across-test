'use strict';

angular.
  module('articleDetail').
  component('articleDetail', {
    templateUrl: 'scripts/app/article-detail/article-detail.template.html',
      controller: ['$routeParams', 'Article',
          function ($routeParams, Article) {
              this.article = Article.get({ articleId: $routeParams.articleId });
          }
      ]
  });
