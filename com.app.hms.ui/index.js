var securityApp = angular.module('SecurityApp', ['ngAnimate', 'ngLoadScript', 'ui.bootstrap', 'ui.router',
                                                'ui.grid', 'ui.grid.selection', 'ui.grid.exporter', 'ui.grid.pagination',
                                                'ngNotify', 'flow.provider', 'ngStorage', 'frapontillo.bootstrap-duallistbox',
                                                'uiSwitch']);

securityApp.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise('/Login');

    $stateProvider
        .state('Login',
        {
            url: '/Login',
            templateUrl: 'App/Login/Login.html',
            controller: 'LoginController'
        })
        .state('Home',
        {
            url: '/Home',
            templateUrl: 'App/Dashboard/Dashboard.html',
            controller: 'DashboardController'
        })
        .state('AddPatient',
        {
            url: '/AddPatient',
            templateUrl: 'App/Patient/AddPatient.html',
            controller: 'AddPatientController'
        })
        .state('EditPatient',
        {
            url: '/EditPatient',
            templateUrl: 'App/Patient/EditPatient.html',
            controller: 'AddPatientController'
        })
        .state('DoctorManagement',
        {
            url: '/DoctorManagement',
            templateUrl: 'App/ClientsManagement/DoctorManagement.html',
            controller: 'ClientManagementController'
        })
        .state('RetrievePatient',
        {
            url: '/RetrievePatient',
            templateUrl: 'App/Patient/RetrievePatient.html',
            controller: 'RetrievePatientController'
        })
});