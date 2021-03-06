﻿'use strict';

// Google Analytics Collection APIs Reference:
// https://developers.google.com/analytics/devguides/collection/analyticsjs/

angular.module('app.controllers', [])

    // Path: /
    .controller('DefaultCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function() {
            $http.put("../api/Default", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('MoreInfoCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/MoreInfo", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('HomeCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/Home", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('AutoCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/Auto", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('MotorcycleCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/Motorcycle", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('FinalQuoteCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/FinalQuote", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    .controller('SelectQuoteCtrl', ['$scope', '$location', '$window', "$http", function ($scope, $location, $window, $http) {
        $scope.model = {};
        $scope.person = $scope.$root.data.user;
        $scope.$root.title = 'AngularJS SPA Template for Visual Studio';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
        $scope.nextPage = function () {
            $http.put("../api/SelectQuote", $scope.model).then(function (result) {
                $scope.$root.data = result.data;
                $location.path(result.data.pageName.replace(/"/g, ""));
            });
        };
    }])

    // Path: /error/404
    .controller('Error404Ctrl', ['$scope', '$location', '$window', function ($scope, $location, $window) {
        $scope.$root.title = 'Error 404: Page Not Found';
        $scope.$on('$viewContentLoaded', function () {
            $window.ga('send', 'pageview', { 'page': $location.path(), 'title': $scope.$root.title });
        });
    }]);