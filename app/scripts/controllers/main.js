'use strict';

/**
 * @ngdoc function
 * @name codeJamFrontEndApp.controller:MainCtrl
 * @description
 * # MainCtrl
 * Controller of the codeJamFrontEndApp
 */
angular.module('codeJamFrontEndApp')
  .controller('MainCtrl', function ($scope) {
    $scope.awesomeThings = [
      'HTML5 Boilerplate',
      'AngularJS',
      'Karma'
    ];
  });
