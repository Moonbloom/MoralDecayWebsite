app.directive('ngBackImg', function () {
    return function (scope, element, attrs) {
        attrs.$observe('ngBackImg', function (value) {
            element.css({
                'background-image': 'url(' + value + ')',
                'background-size': 'cover'
            });
        });
    };
});