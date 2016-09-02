groupApp.controller("scrollController", function ($scope, $anchorScroll, $location) {
    $scope.gotoAnchor = function (elemId) {
        $anchorScroll(elemId);
    };
});