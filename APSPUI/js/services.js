/**
 * Created by Fran Rodriguez on 17/04/2016
 */


angular.module('ApspApp.services', []).factory('ApspFactory', function ($resource, $http) {
    return {
        showAllPersons: function () {
            return $http.get('http://localhost/APSP/QueryService.svc/getAllPersons').
               success(function (data, status, headers, config) {
                 
               }).
               error(function (data, status, headers, config) {
                  
               });

        },

        showVillanos: function () {
            return $http.get('http://localhost/APSP/QueryService.svc/getVillanos').
               success(function (data, status, headers, config) {
               

               }).
               error(function (data, status, headers, config) {
                   

               });

        },

        showSuperHeroes: function () {
            return $http.get('http://localhost/APSP/QueryService.svc/getSuperHeroes').
               success(function (data, status, headers, config) {


               }).
               error(function (data, status, headers, config) {


               });

        },

        saveVillanos: function () {
            return $http.post('http://localhost/APSP/QueryService.svc/saveVillanos').
               success(function (data, status, headers, config) {


               }).
               error(function (data, status, headers, config) {


               });

        },

        saveSuperHeroes: function () {
             return $http.post('http://localhost/APSP/QueryService.svc/saveSuperHeroes').
           success(function (data, status, headers, config) {


           }).
           error(function (data, status, headers, config) {


           });

    }

    }

}).service('apspService', function ($http, $window) {


    this.showPopup = function (message) {
        return $window.confirm(message);
    }
});