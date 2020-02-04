'use strict';

angular.
  module('articleList').
  component('articleList', {
      templateUrl: 'scripts/app/article-list/article-list.template.html',
      controller: ['Article',
          function (Article) {
              var self = this;

              self.load = function() {
                  self.articles = Article.query();
              };

              self.delete = function (article) {
                  Article.delete({ articleId: article.Id }).$promise.then(self.load);
              };

              self.load();
          }
      ]
  });
