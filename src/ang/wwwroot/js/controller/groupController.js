groupApp.controller("groupController", function ($scope, $http, $location) {
    $http.get('../../api/groups').success(function (data) {
        $scope.groups = data;
    });

    $scope.hidden = true;
    $scope.selectedGroup = {};
    $scope.selectGroup = function (group) {
        $scope.selectedGroup = group;
        $scope.hidden = false;
    };
});