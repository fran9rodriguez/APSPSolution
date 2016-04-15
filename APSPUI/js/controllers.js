/**
 * Created by Fran Rodriguez on 23/09/2015
 */


angular.module('ApspApp.controllers', []).controller('queryController', function ($scope, $http, apspService, ApspFactory) {

    $scope.loadPersons = function () {
        ApspFactory.showAllPersons().then(
         function (response) {
             $scope.Persons = response["data"]["lPersons"];
             $scope.totalPersons = $scope.Persons.length;
             console.log($scope.Persons);
         }
        );
    }

      
    $scope.loadPersons();

}).controller('villanosController', function ($scope, $http, apspService, ApspFactory) {

   $scope.loadVillanos = function () {
        ApspFactory.showVillanos().then(
         function (response) {
             $scope.Villanos = response["data"]["lPersons"];
             $scope.totalVillanos = $scope.Villanos.length;
             console.log($scope.Villanos);
         }
        );
    }


   $scope.loadVillanos();

}).controller('saveVillanosController', function ($scope, $http, apspService, ApspFactory) {

    $scope.loadVillanos = function () {
        ApspFactory.showVillanos().then(
         function (response) {
             $scope.Villanos = response["data"]["lPersons"];
             $scope.totalVillanos = $scope.Villanos.length;
             console.log($scope.Villanos);
         }
        );
    }

    $scope.saveVillanos = function () {
        ApspFactory.saveVillanos().then(
         function (response) {
             $scope.loadVillanos();
         }
        );
    }


    $scope.saveVillanos();

}).controller('superheroesController', function ($scope, $http, apspService, ApspFactory) {

    $scope.loadSuperHeroes = function () {
        ApspFactory.showSuperHeroes().then(
         function (response) {
             $scope.SuperHeroes = response["data"]["lPersons"];
             $scope.totalSuperHeroes = $scope.SuperHeroes.length;
             console.log($scope.SuperHeroes);
         }
        );
    }


    $scope.loadSuperHeroes();

}).controller('saveSuperHeroesController', function ($scope, $http, apspService, ApspFactory) {

    $scope.loadSuperHeroes = function () {
        ApspFactory.showSuperHeroes().then(
         function (response) {
             $scope.SuperHeroes = response["data"]["lPersons"];
             $scope.totalSuperHeroes = $scope.SuperHeroes.length;
             console.log($scope.SuperHeroes);
         }
        );
    }

    $scope.saveSuperHeroes = function () {
        ApspFactory.saveSuperHeroes().then(
         function (response) {
             $scope.loadSuperHeroes();
         }
        );
    }


    $scope.saveSuperHeroes();

});