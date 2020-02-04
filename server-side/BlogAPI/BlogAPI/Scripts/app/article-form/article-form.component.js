'use strict';

angular.
  module('articleForm').
  component('articleForm', {
      templateUrl: 'scripts/app/article-form/article-form.template.html',
      controller: ['$location', 'Article',
          function ($location, Article) {
              var self = this;

              this.save = function() {
                  var data = {
                      title: self.title,
                      pubDate: self.pubDate,
                      text: self.text
                  };

                  var newArticle = new Article(data);
                  newArticle.$save().then(function() {
                      $location.path("/login");
                  });
              };
          }
      ]
  });
