/// <reference path="../Views/Home/AngularViews/Home.html" />
/// <reference path="../Views/Home/AngularViews/Home.html" />
/// <reference path="../Views/Home/AngularViews/Home.html" />
'use strict';

// Declares how the application should be bootstrapped. See: http://docs.angularjs.org/guide/module
angular.module('app', ['ngRoute', 'app.filters', 'app.services', 'app.directives', 'app.controllers'])

    // Gets executed during the provider registrations and configuration phase. Only providers and constants can be
    // injected here. This is to prevent accidental instantiation of services before they have been fully configured.
    .config([
        '$routeProvider', function ($routeProvider) {
            $routeProvider.when("/", {
                templateUrl: "/AngularViews/Default.html"
            }).when("/SelectQuote", {
                templateUrl: "/AngularViews/SelectQuote.html"
            }).when("/Auto", {
                templateUrl: "/AngularViews/Auto.html"
            }).when("/FinalQuote", {
                templateUrl: "/AngularViews/FinalQuote.html"
            }).when("/Motorcycle", {
                templateUrl: "/AngularViews/Motorcycle.html"
            }).when("/Home", {
                templateUrl: "/AngularViews/Home.html"
            });
        }
    ]);