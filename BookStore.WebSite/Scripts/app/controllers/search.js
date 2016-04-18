(function () {

    angular.module('bookStore', ['ngAnimate', 'angular-loading-bar'])
        .controller('mainCtrl', mainCtrl);
    //.config(['cfpLoadingBarProvider', function (cfpLoadingBarProvider) {
    //        cfpLoadingBarProvider.includeBar = true;
    //        cfpLoadingBarProvider.parentSelector = '#loading-bar-container';
    //        cfpLoadingBarProvider.spinnerTemplate = '<div><span class="fa fa-spinner">Custom Loading Message...</div>';
    //    }]);

    function mainCtrl($scope, $http) {
        $scope.getBooks = getBooks;

        $scope.isbns = '9788741201122\n9788702168044';

        $scope.loadMore = loadMore;

        var all = [];
        var pageSize = 10;
        var itemNumber = 0;

        function getBooks() {
            $scope.books = [];
            itemNumber = 0;
            all = $scope.isbns.split('\n');
            loadMore();
        }


        function loadMore() {
            var temparray = all.slice(itemNumber, itemNumber + pageSize);
            itemNumber += pageSize;
            $scope.enableLoadMore = temparray.length === pageSize;
            getService(temparray);
        }

        function getService(arr) {
            $http.post("search/GetBooksByIsbns", { isbns: arr }).success(successHandler);
        }


        function successHandler(data) {
            $scope.books = $scope.books.concat(data);
        }

    }
})();