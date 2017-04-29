angular.module('PortfolioApp', [
  'ngRoute',
  'PortfolioApp.Services',
  'PortfolioApp.Controllers',
  'ui.bootstrap'
]).
config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.
      when("/", { templateUrl: "partials/home.html", controller: "homeController" }).
      when("/projects/:id", { templateUrl: "partials/project.html", controller: "projectController" }).
      when("/projects", { templateUrl: "partials/projects.html", controller: "projectsController" }).
      when("/about", { templateUrl: "partials/contact.html", controller: "contactController" });

    // use the HTML5 History API
    $locationProvider.hashPrefix('');
}]);