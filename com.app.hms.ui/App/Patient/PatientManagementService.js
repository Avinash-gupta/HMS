securityApp.service('PatientManagementService',function($http,$q){

    this.addPatient = function (patientInfoEntity) {
        var defer = $q.defer();
        $http.post('http://localhost:4819/Patient/Add', patientInfoEntity)
            .then(function (data) {
                defer.resolve(data.data);
            })
            .catch(function (fallback) {
                defer.resolve(null);
            });

        return defer.promise;
    };

    this.getPatient = function (id) {
        var defer = $q.defer();
        $http.get('http://localhost:4819/Patient/Get/'+id)
        .then(function(data){
            defer.resolve(data.data);
        })
        .catch(function (fallback){
            defer.resolve(null);
        });
        return defer.promise;
    };

    this.updatePatient = function (patientInfoEntity) {
        var defer = $q.defer();
        $http.post('http://localhost:4819/Patient/Update', patientInfoEntity)
            .then(function (data) {
                defer.resolve(data.data);
            })
            .catch(function (fallback) {
                defer.resolve(null);
            });

        return defer.promise;
    };
});