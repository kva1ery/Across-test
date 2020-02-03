angular.module('core.article').
    factory('Article', ['$resource', 
    function($resource) {
        return $resource('api/Articles/:articleId');
    }
]);