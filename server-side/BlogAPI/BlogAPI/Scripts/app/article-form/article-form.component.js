'use strict';

angular.
  module('articleForm').
  component('articleForm', {
      templateUrl: 'scripts/app/article-form/article-form.template.html',
      controller: ['$location', '$routeParams', 'Article',
          function ($location, $routeParams, Article) {
              var self = this;

              if ($routeParams.articleId) {
                  this.article = Article.get({ articleId: $routeParams.articleId });
              } else {
                  this.article = new Article({
                      Id: null,
                      Title: '',
                      PubDate: '',
                      Text: ''
                  });
              }

              this.save = function() {

                  var newArticle = new Article(this.article);
                  newArticle.$save().then(function() {
                      $location.path('/articles');
                  });
              };
          }
      ]
  });
