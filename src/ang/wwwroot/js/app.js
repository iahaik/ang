var groupApp = angular.module("groupApp", ["ngRoute"])
    .config(function ($routeProvider) {
        $routeProvider.when("/grouplist",
            {
                templateUrl: "views/groupList.html",
                controller: "groupController"
            });
        $routeProvider.when("/participantist",
            {
                templateUrl: "views/participantList.html",
                controller: "participantController"
            });
        $routeProvider.when("/creategroup", 
            {
                templateUrl: "views/createGroup.html",
                controller: "creationController"
            });
        $routeProvider.when("/createparticipant",
            {
                templateUrl: "views/createParticipant.html",
                controller: "creationController"
            });
        $routeProvider.otherwise({redirectTo: "/grouplist"});
    });

groupApp.directive("groupDetail", function () {
    return {
        link: function (scope, element, attrs) {
            scope.data = scope[attrs["groupDetail"]];
        },
        restrict: "EACM",
        templateUrl: "templates/groupDetail.html"
    }
});