app = angular.module('mdWebApp', ['ngRoute']);

app.config(["$routeProvider", "$locationProvider", function ($routeProvider, $locationProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/Views/Pages/frontpage.html'
        })
        .when('/recruitment', {
            templateUrl: '/Views/Pages/recruitment.html'
        });

    $locationProvider.html5Mode(true);
}]);

app.controller('bodyCtrl', ['$scope', function($scope) {

    $scope.leftNavMenuItems = [
        {
            text: "HOME",
            href: "#/"
        },
        {
            text: "FORUM",
            href: "#forum"
        },
        {
            text: "RECRUITMENT",
            href: "#recruitment"
        },
        {
            text: "GALLERY",
            href: "#gallery"
        },
        {
            text: "ABOUT US",
            href: "#about-us"
        }
    ];
}]);