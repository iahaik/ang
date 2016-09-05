groupApp.controller("creationController", function ($scope, $http, $location) {
    $http.get('../../api/groups').success(function (data) {
        $scope.groups = data;
    });

    $scope.createGroup = function (group, groupForm) {
        if(groupForm.$valid) {
            $http.post("../../api/groups", group).success(function (data) {
                $location.path("/grouplist");
            });
        }
    }

    $scope.createParticipant = function (participant, participantForm) {
        if (participantForm.$valid) {
            $http.post("../../api/participants", participant).success(function (data) {
                $location.path("/participantist");
            });
        }
    }
});