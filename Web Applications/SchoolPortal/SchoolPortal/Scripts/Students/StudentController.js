studentModule.controller("studentController", function ($scope, studentService) {
    studentService.getStudents().then(function (students)
    {
        $scope.students = students
    }
        , function ()
        {
            alert("error while fetching data from server");
        })
});