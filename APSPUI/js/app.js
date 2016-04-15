/**
 * Created by Fran Rodriguez 15/04/2016
 */

angular.module('ApspApp', ['ui.router', 'ngResource', 'ApspApp.controllers', 'ApspApp.services']);

angular.module('ApspApp').config(function ($stateProvider, $httpProvider) {
    $stateProvider.state('persons', {
        url: '/persons',
        templateUrl: 'partials/persons.html',
        controller: 'queryController'
    }).state('viewVillanos', {
        url: '/villanos',
        templateUrl: 'partials/viewVillanos.html',
        controller: 'villanosController'
    }).state('saveVillanos', {
        url: '/villanos/save',
        templateUrl: 'partials/viewVillanos.html',
        controller: 'saveVillanosController'
    }).state('viewSuperHeroes', {
        url: '/superheroes',
        templateUrl: 'partials/viewSuperHeroes.html',
        controller: 'superheroesController'
    }).state('saveSuperHeroes', {
        url: '/superheroes/save',
        templateUrl: 'partials/viewSuperHeroes.html',
        controller: 'saveSuperHeroesController'
    });
}).run(function ($state) {
    $state.go('persons');
});