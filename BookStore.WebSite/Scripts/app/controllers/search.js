(function (angular) {

    angular.module('bookStore')
        .controller('mainCtrl', mainCtrl);

    function mainCtrl($scope, $http, Notification) {
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
            $http.post("search/GetBooksByIsbns", { isbns: arr }).then(successHandler,failureHandler);
        }


        function successHandler(response) {
            $scope.books = $scope.books.concat(response.data);
        }

        function failureHandler() {
              Notification.error({message: 'Server error', delay: 1000});
        }

    }
})(angular);