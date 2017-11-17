mainApp.controller("studentController", function ($scope) {
    $scope.student = {
        firstname: "Meenal",
        lastname: "Bubbar",
        fees: 700,
        subjects: [
            {name: 'Physics', marks:90},
            {name:'Chemistry',marks:100},
            {name: 'Maths',marks:200},
            {name:'History',marks:400}
        ]
    }
    //$scope.reset = function()
    //{
    //    $scope.firstname = "Neha",
    //    $scope.lastname ="Sharma",
    //    $scope.fees = 100
        
    //}
});
