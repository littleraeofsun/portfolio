angular.module('PortfolioApp', [
  'ngRoute',
  'PortfolioApp.Services',
  'PortfolioApp.Controllers'
]).
config(['$routeProvider', function ($routeProvider) {
    $routeProvider.
      when("/", { templateUrl: "partials/home.html", controller: "homeController" }).
      when("/projects/:id", { templateUrl: "partials/project.html", controller: "projectController" }).
      when("/projects", { templateUrl: "partials/projects.html", controller: "projectsController" }).
      when("/albums/:id", { templateUrl: "partials/album.html", controller: "albumController" }).
      when("/albums", { templateUrl: "partials/albums.html", controller: "albumsController" });
      //when("/drivers", { templateUrl: "partials/drivers.html", controller: "driversController" }).
      //when("/drivers/:id", { templateUrl: "partials/driver.html", controller: "driverController" }).
      //when("/teams", { templateUrl: "partials/teams.html", controller: "teamsController" }).
      //when("/teams/:id", { templateUrl: "partials/team.html", controller: "teamController" }).
      //when("/races", { templateUrl: "partials/races.html", controller: "racesController" }).
      //when("/races/:id", { templateUrl: "partials/race.html", controller: "raceController" });
}]);