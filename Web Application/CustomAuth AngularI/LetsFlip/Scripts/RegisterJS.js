var app = angular.module("RegisterApp", []);
app.controller("registercrtl", function ($scope) {
    $scope.saveUser = function (userInfo) {
        console.log(userInfo);
    }
});