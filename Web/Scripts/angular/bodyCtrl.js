app = angular.module('mdWebApp', []);

app.controller('bodyCtrl', [
    '$scope', function($scope) {

    $scope.leftNavMenuItems = [
        {
            text: "HOME",
            href: "/"
        },
        {
            text: "FORUM",
            href: "/forum"
        },
        {
            text: "RECRUITMENT",
            href: "/recruitment"
        },
        {
            text: "GALLERY",
            href: "/gallery"
        },
        {
            text: "ABOUT US",
            href: "/about-us"
        }
    ];
}]);