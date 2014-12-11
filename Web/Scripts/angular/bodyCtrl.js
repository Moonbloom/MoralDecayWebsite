app = angular.module('mdWebApp', ['ngRoute']);

var titleAppend = " - Moral Decay - Sunstrider";

app.config(["$routeProvider", function($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: '/Views/Pages/frontpage.html',
            title: "Frontpage"
        })
        .when('/recruitment', {
            templateUrl: '/Views/Pages/recruitment.html',
            title: "Recruitment"
        })
        .otherwise({
            templateUrl: '/Views/Pages/error.html',
        });
}]);

app.run(['$location', '$rootScope', function ($location, $rootScope) {
    $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
        if (current.$$route != null) {
            $rootScope.title = current.$$route.title + titleAppend;
        } else {
            $rootScope.title = "404 - Page not found" + titleAppend;
        }
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