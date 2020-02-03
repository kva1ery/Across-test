'use strict';

angular.
  module('articleList').
  component('articleList', {
      templateUrl: 'scripts/app/article-list/article-list.template.html',
      controller: ['Article',
          function (Article) {
              this.articles = Article.query();
          }
      ]
  });
