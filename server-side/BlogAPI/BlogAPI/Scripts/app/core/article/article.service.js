angular.module('core.article').
    factory('Article', ['$resource', 
    function($resource) {
        return $resource('localhost:5000/api/Articles/:articleId');
    }
]);