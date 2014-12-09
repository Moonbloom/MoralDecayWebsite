app.controller('frontpageCtrl', ['$scope', '$http', '$sce', function ($scope, $http, $sce) {

    //Used to format raw HTML correctly on the view
    $scope.inputRawHtml = function(rawHtml) {
        return $sce.trustAsHtml(rawHtml);
    }

    //Get all current posts
    //$http.get("/api/Post").success(function (posts) {

    //    var fixedPosts = $.map(posts, function (element) {
    //        return {
    //            Id: element.Id,
    //            Headline: element.Header,
    //            RawHtml: element.Text,
    //            Active: element.Active,
    //            CreatedOnDate: element.CreatedOn,
    //            ModifiedOnDate: element.ModifiedOn
    //        }
    //    });

    //    $scope.frontpagePosts = fixedPosts;
    //});
}]);