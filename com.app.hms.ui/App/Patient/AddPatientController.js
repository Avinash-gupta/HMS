securityApp.controller('AddPatientController', function($scope,$window, $location, ngNotify,$state, PatientManagementService){
    $scope.editMode = false;
    if ($state.current.name == "EditPatient") {
        $scope.editMode = true;
    }

    $scope.addPatient = function () {
        $scope.patientInfoEntity.Id = 0;
            PatientManagementService.addPatient($scope.patientInfoEntity).then(function (result) {
                if (result != null) {
                    ngNotify.set('Patient Created successfully',
                    {
                        theme: 'pure',
                        position: 'bottom',
                        duration:3000,
                        type: 'success',
                        button: 'true',
                        html: 'false',
                    });
                   alert("Patient Id :" +result);
                } else {
                    ngNotify.set('Patient Creation failed',
                    {
                        theme: 'pure',
                        position: 'bottom',
                        duration:3000,
                        type: 'error',
                        button: 'true',
                        html: 'false',
                    });
                }
                $location.path('/Home');
            })
    };
});
       
