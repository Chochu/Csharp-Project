/// <reference path="angular-resource.js" />
/// <reference path="angular-animate.min.js" />
/// <reference path="angularjs.min.js" />
//https://rsbuddy.com/exchange/summary.json
var app = angular.module('mainApp', ['jsonService', 'ui.router', 'chart.js']);

app.config(function ($stateProvider, $urlMatcherFactoryProvider, $urlRouterProvider) {
    $urlMatcherFactoryProvider.caseInsensitive(true);
    $urlRouterProvider.otherwise("/home");
    $stateProvider
    .state('home', {
        url: "/home",
        templateUrl: "/Home/genTable",
        controller: "crtl1"
    })
    .state('graph', {
        url: "/graph/:id/:name",
        templateUrl: "/Home/genChart",
        controller: "crtl2"
    })
});

app.controller('crtl1', function ($scope, $http) {
    $scope.loading = true;
    var temp = [];
    var temptoappend = [];
    $http({
        url: "/Home/itemTable",
        method: "get",
        cache: true
    })
    .then(function (response) {
        temp = JSON.parse(response.data);
        angular.forEach(temp[0], function (value, key) {
            if (value.buy_average == 0) {
                value.margin = 0;
            }
            else
                value.margin = value.sell_average - value.buy_average;
            temptoappend.push(value);
        });
        $scope.jsonda = temptoappend;
        $scope.loading = false;
    });

    //Which column to sort
    $scope.sortColumn = "id";
    //Reversed sort the column?
    $scope.reverseSort = false;

    $scope.sortData = function (column) {
        $scope.reverseSort = ($scope.sortColumn == column) ? !$scope.reverseSort : false;
        $scope.sortColumn = column;
    }

    $scope.getSortClass = function (column) {
        if ($scope.sortColumn == column) {
            return $scope.reverseSort ? 'arrow-down' : 'arrow-up';
        }
        return '';
    }
});


app.controller('crtl2', function ($stateParams, $scope, $http, $location) {
    //init load
    var temp = [];
    $http({
        method: "get",
        url: "/Home/getchartid/" + $stateParams.id,
        cache: true
    })
    .then(function (response) {
        temp = JSON.parse(response.data);

        $scope.labels = [];
        $scope.series = ['Buy', 'Sell'];
        $scope.buyingprice = [];
        $scope.sellingprice = [];
        angular.forEach(temp, function (value, key) {
            var tempdate = new Date(value.ts)
            $scope.labels.push(tempdate.getMonth() + "/" + tempdate.getDate() + "/" + tempdate.getFullYear() + " " + formatAMPM(tempdate));
            $scope.buyingprice.push(value.buyingPrice);
            $scope.sellingprice.push(value.sellingPrice);
        });
        $scope.data = [$scope.buyingprice, $scope.sellingprice];
        temp = [];
        $scope.onClick = function (points, evt) {
            console.log(points, evt);
        };

    });

    $scope.itemname = $stateParams.name

    $scope.setintdp = function () {
        $http({
            method: "get",
            url: "/Home/getchartidgstart/" + $stateParams.id + "?g=" + $scope.selectedinterval + "&start=" + new Date($scope.selectedDP).getTime(),
            cache: true
        })
        .then(function (response) {
            temp = JSON.parse(response.data);
            $scope.labels = [];
            $scope.series = ['Buy', 'Sell'];
            $scope.buyingprice = [];
            $scope.sellingprice = [];
            angular.forEach(temp, function (value, key) {
                var tempdate = new Date(value.ts);
                $scope.labels.push(tempdate.getMonth() + "/" + tempdate.getDate() + "/" + tempdate.getFullYear() + " " + formatAMPM(tempdate));
                $scope.buyingprice.push(value.buyingPrice);
                $scope.sellingprice.push(value.sellingPrice);
            });
            $scope.data = [$scope.buyingprice, $scope.sellingprice];

            $scope.onClick = function (points, evt) {
                console.log(points, evt);
            };
        });
    };

});

app.directive('resolveLoader', function ($rootScope, $timeout) {

    return {
        restrict: 'E',
        replace: true,
        template: '<div class="alert alert-success ng-hide"><strong>Welcome!</strong> Content is loading, please hold.</div>',
        link: function (scope, element) {

            $rootScope.$on('$routeChangeStart', function (event, currentRoute, previousRoute) {
                if (previousRoute) return;

                $timeout(function () {
                    element.removeClass('ng-hide');
                });
            });

            $rootScope.$on('$routeChangeSuccess', function () {
                element.addClass('ng-hide');
            });
        }
    };
});

app.directive('jqdatepicker', function () {
    return {
        restrict: 'A',
        require: 'ngModel',
        link: function (scope, element, attrs, ngModelCtrl) {
            $(function () {
                element.datepicker({
                    dateFormat: 'mm/dd/yy',
                    onSelect: function (date) {
                        scope.$apply(function () {
                            ngModelCtrl.$setViewValue(date);
                        });
                    }
                });
            });
        }
    }
});

angular.module('jsonService', ['ngResource'])
    .factory('JsonService', function ($resource) {
        return $resource('/Home/itemTable', {}, {
            get: {
                method: 'GET',
                transformResponse: function (data) {
                    return angular.fromJson(data).list;
                },
                isArray: true
            }
        });
    });

function formatAMPM(date) {
    var hours = date.getHours();
    var minutes = date.getMinutes();
    var ampm = hours >= 12 ? 'pm' : 'am';
    hours = hours % 12;
    hours = hours ? hours : 12; // the hour '0' should be '12'
    minutes = ('0' + minutes).slice(-2);
    var strTime = hours + ':' + minutes + ' ' + ampm;
    return strTime;
}