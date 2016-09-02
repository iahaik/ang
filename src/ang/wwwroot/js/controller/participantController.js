groupApp.controller("participantController", function ($scope, $http, $location) {
    $http.get('../../api/participants').success(function (data) {
        $scope.participants = data;
    });
});