var MVCServiceWithAngular = angular.module('MVCServiceWithAngular', ['ui.Route', 'ui.bootstrap']);

MVCServiceWithAngular.controller('LandingPageController', LandingPageController);
MVCServiceWithAngular.controller('LoginController', LoginController);
MVCServiceWithAngular.controller('RegisterController', RegisterController);

MVCServiceWithAngular.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
MVCServiceWithAngular.factory('LoginFactory', LoginFactory);
MVCServiceWithAngular.factory('RegistrationFactory', RegistrationFactory);

var configFunction = function ($routeProvider, $httpProvider, $locationProvider) {

    $locationProvider.hashPrefix('!').html5Mode(true);

    $routeProvider.
        when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function (params) { return '/routesDemo/two?donuts=' + params.donuts; }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegisterController
        });


   $httpProvider.interceptors.push('AuthHttpResponseInterceptor'); 
}
configFunction.$inject = ['$routeProvider', '$httpProvider', '$locationProvider'];
//configFunction.$inject = ['$routeProvider'];

MVCServiceWithAngular.config(configFunction);