'use strict';

// Declare app level module which depends on views, and core components
angular.module('blogApp', [
  'ngRoute',
  'core',
  'articleList',
  'articleDetail',
  'articleForm'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
  $locationProvider.hashPrefix('!');

  $routeProvider.when('/articles', {
    template: '<article-list></article-list>'
  }).
  when('/article/:articleId', {
    template: '<article-detail></article-detail>'
  }).
  when('/new-article/', {
      template: '<article-form></article-form>'
  }).
  when('/edit-article/:articleId', {
      template: '<article-form></article-form>'
  }).
  otherwise({redirectTo: '/articles'});
}]);
