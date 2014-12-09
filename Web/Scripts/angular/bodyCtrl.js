﻿app = angular.module('mdWebApp', ['ngRoute']);

app.config(["$routeProvider", function($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/Views/Pages/frontpage.html',
            controller: 'frontpageCtrl'
        })
        .when('/recruitment', {
            templateUrl: '/Views/Pages/recruitment.html',
            controller: 'recruitmentCtrl'
        });
}]);

app.controller('bodyCtrl', ['$scope', function($scope) {

    $scope.leftNavMenuItems = [
        {
            text: "HOME",
            href: "#/"
        },
        {
            text: "FORUM",
            href: "#/forum"
        },
        {
            text: "RECRUITMENT",
            href: "#/recruitment"
        },
        {
            text: "GALLERY",
            href: "#/gallery"
        },
        {
            text: "ABOUT US",
            href: "#/about-us"
        }
    ];
}]);