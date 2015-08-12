studentModule.factory("studentService", function ($http, $q) {
    return {
        getStudents: function () {

            //get the deferred object
            var deferred = $q.defer();
            $http({ method: 'GET', url: '/Student/GetStudentDetails' }).success(deferred.resolve).error(deferred.reject);
            //return the promise
            return deferred.promise;
        }
    }
});

studentModule.factory("addStudentService", function ($http, $q) {

});