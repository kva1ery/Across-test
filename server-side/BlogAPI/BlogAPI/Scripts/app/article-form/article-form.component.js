'use strict';

angular.
  module('articleForm').
  component('articleForm', {
      templateUrl: 'scripts/app/article-form/article-form.template.html',
      controller: ['$location', '$routeParams', 'Article',
          function ($location, $routeParams, Article) {
              var self = this;

              if ($routeParams.articleId) {
                  this.article = Article.get({ articleId: $routeParams.articleId }, function(article) {
                      article.date = new Date(article.PubDate);
                  });
              } else {
                  this.article = new Article({
                      Id: null,
                      Title: '',
                      date: new Date(),
                      Text: ''
                  });
              }

              this.save = function() {
                  this.article.PubDate = new Date(this.article.date);
                  this.article.$save().then(function() {
                      $location.path('/articles');
                  });
              };
          }
      ]
  });
