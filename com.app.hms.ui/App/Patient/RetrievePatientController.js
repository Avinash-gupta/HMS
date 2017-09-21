securityApp.controller('RetrievePatientController', function($scope,$window, $location, ngNotify, PatientManagementService){
    $scope.showPatientDetails = false;

    $scope.GetPatient = function() {
        PatientManagementService.getPatient($scope.patientInfoEntity.Id).then(function (result) {
            if (result != null) {
                $scope.patientInfoEntity = result;
                ngNotify.set('Patient retrieved successfully',
                {
                    theme: 'pure',
                    position: 'bottom',
                    duration:2000,
                    type: 'success',
                    button: 'true',
                    html: 'false',
                });
                $scope.showPatientDetails = true;
            } else {
                ngNotify.set('Patient retrieval failed',
                {
                    theme: 'pure',
                    position: 'bottom',
                    duration:3000,
                    type: 'error',
                    button: 'true',
                    html: 'false',
                });
            }
            $location.path('/RetrievePatient');
        
        }
    )};
});
    