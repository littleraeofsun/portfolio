angular.module('PortfolioApp.Services', [])
  .factory('portfolioAPIservice', function ($http) {

      var portfolioAPI = {};

      /*
      getPortfolioItems: get projects and albums
      getFeaturedItems: get featured projects (albums: meh)
      getProjects
      getAlbums
      getProject
      getAlbum
      getProjectMedia
      getAlbumMedia

      --

      search
      */

      portfolioAPI.getEmail = function () {
          return $http({
              method: 'POST',
              url: '/api/Email'
          });
      }

      portfolioAPI.getFeaturedItems = function () {
          return $http({
              method: 'GET',
              url: '/api/Projects/Featured'
          });
      }

      portfolioAPI.getProject = function (id) {
          return $http({
              method: 'GET',
              url: '/api/Projects/' + id
          });
      }

      portfolioAPI.getProjectMedia = function (id) {
          return $http({
              method: 'GET',
              url: '/api/Projects/' + id + '/Media'
          });
      }

      portfolioAPI.getProjects = function () {
          return $http({
              method: 'GET',
              url: '/api/Projects'
          });
      }

      portfolioAPI.getAlbum = function (id) {
          return $http({
              method: 'GET',
              url: '/api/Albums/' + id
          });
      }

      portfolioAPI.getAlbumMedia = function (id) {
          return $http({
              method: 'GET',
              url: '/api/Albums/' + id + '/Media'
          });
      }

      portfolioAPI.getAlbums = function () {
          return $http({
              method: 'GET',
              url: '/api/Albums'
          });
      }

      //portfolioAPI.getDriverDetails = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/drivers/' + id + '/driverStandings.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getDriverRaces = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/drivers/' + id + '/results.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getTeams = function () {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/constructorStandings.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getTeamDetails = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/constructors/' + id + '/constructorStandings.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getTeamRaces = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/constructors/' + id + '/results.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getRaceWinners = function () {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/results/1.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getRaces = function () {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getRaceDetails = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/' + id + '/results.json?callback=JSON_CALLBACK'
      //    });
      //}

      //portfolioAPI.getQualiDetails = function (id) {
      //    return $http({
      //        method: 'JSONP',
      //        url: 'http://ergast.com/api/f1/2013/' + id + '/qualifying.json?callback=JSON_CALLBACK'
      //    });
      //}

      return portfolioAPI;
  });