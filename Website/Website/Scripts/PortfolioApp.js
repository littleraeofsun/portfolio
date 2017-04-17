angular.module('PortfolioApp', [
  'ngRoute',
  'PortfolioApp.Services',
  'PortfolioApp.Controllers'
]).
config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
    $routeProvider.
      when("/", { templateUrl: "partials/home.html", controller: "homeController" }).
      when("/projects/:id", { templateUrl: "partials/project.html", controller: "projectController" }).
      when("/projects", { templateUrl: "partials/projects.html", controller: "projectsController" }).
      when("/albums/:id", { templateUrl: "partials/album.html", controller: "albumController" }).
      when("/albums", { templateUrl: "partials/albums.html", controller: "albumsController" }).
      when("/contact", { templateUrl: "partials/contact.html", controller: "contactController" });

    // use the HTML5 History API
    $locationProvider.hashPrefix('');
}]);