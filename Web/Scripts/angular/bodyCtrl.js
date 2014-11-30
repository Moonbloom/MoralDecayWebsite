app = angular.module('mdWebApp', []);

app.controller('bodyCtrl', [
    '$scope', function($scope) {

    $scope.leftNavMenuItems = [
        {
            text: "Home",
            href: "/"
        },
        {
            text: "Forum",
            href: "/forum"
        },
        {
            text: "Recruitment",
            href: "/recruitment"
        },
        {
            text: "Gallery",
            href: "/gallery"
        },
        {
            text: "About",
            href: "/about"
        }
    ];
}]);