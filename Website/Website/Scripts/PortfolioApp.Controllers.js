angular.module('PortfolioApp.Controllers', [])

  //MENU CONTROLLER
  .controller('menuController', function($scope){
      $scope.temp = "temp";
  })

  //HOME CONTROLLER
  .controller('homeController', function ($scope, portfolioAPIservice) {
  	document.title = "littleraeofsun: Portfolio of Rae Melton";
  	$scope.projects = [];
  	portfolioAPIservice.getFeaturedItems().then(function (response) {
  		if (response.status === 200) {
  			$scope.projects = response.data;
  		}
		//TODO: handle failure
  	});

	//apply scroll button functionality after view loaded
  	$scope.$on('$viewContentLoaded', function () {
  		$('.scroll-button').click(function () {
  			var tar = $(this).attr('scroll-target');
  			if (tar != "") {
  				$('html, body').animate({
  					scrollTop: $(tar).offset().top
  				}, 1000);
  			}
  		});
  	});
  })

  //PROJECT CONTROLLER
  .controller('projectController', function ($scope, $routeParams, portfolioAPIservice) {
  	document.title = "Project Title | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.project = null;

  	portfolioAPIservice.getProject($scope.id).then(function (response) {
  		if (response.status === 200) {
  			document.title = response.data.Title + " | littleraeofsun";
  			$scope.project = response.data;

  			//split description in paragraphs (discard last which is empty)
  			$scope.project.DescriptionParagraphs = $scope.project.Description.split('\n');

			//convert comma-delimited strings into arrays
  			$scope.project.Tools = $scope.project.Tools.replace(/\s/g, '').split(',');

  			portfolioAPIservice.getProjectMedia($scope.id).then(function (response) {
  				if (response.status === 200) {
  					$scope.project.Media = response.data;
  				}
  			});
  		}
  		//TODO: handle failure
  	});
  })

  //PROJECTS CONTROLLER
  .controller('projectsController', function ($scope, $routeParams, portfolioAPIservice) {
  	document.title = "Projects | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.projects = [];

  	portfolioAPIservice.getProjects().then(function (response) {
  		if (response.status === 200) {
  			$scope.projects = response.data;
  		}
  		//TODO: handle failure
  	});
  })

  //ALBUM CONTROLLER
  .controller('albumController', function ($scope, $routeParams, portfolioAPIservice) {
  	document.title = "Album Title | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.album = null;

  	portfolioAPIservice.getAlbum($scope.id).then(function (response) {
  		if (response.status === 200) {
  			document.title = response.data.Name + " | littleraeofsun";
  			$scope.album = response.data;

  			portfolioAPIservice.getAlbumMedia($scope.id).then(function (response) {
  				if (response.status === 200) {
  					$scope.album.Media = response.data;
  				}
  			});
  		}
  		//TODO: handle failure
  	});

  	//apply scroll button functionality after view loaded
  	$scope.$on('$viewContentLoaded', function () {
  		$('.section-loader').fadeOut(500);
  	});
  })

  //ALBUMS CONTROLLER
  .controller('albumsController', function ($scope, $routeParams, portfolioAPIservice) {
  	document.title = "Albums | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.albums = [];

  	portfolioAPIservice.getAlbums().then(function (response) {
  		if (response.status === 200) {
  			$scope.albums = response.data;
  		}
  		//TODO: handle failure
  	});

  	//apply scroll button functionality after view loaded
  	$scope.$on('$viewContentLoaded', function () {
  		$('.section-loader').fadeOut(500);
  	});
  })

  //CONTACT CONTROLLER
  .controller('contactController', function ($scope, portfolioAPIservice) {
  	document.title = "Contact Me | littleraeofsun";

  	//run script after view loaded
  	$scope.$on('$viewContentLoaded', function () {

  	});
  })


  ////RACES CONTROLLER
  //.controller('racesController', function ($scope, $http, ergastAPIservice) {
  //	$scope.pastRaces = [];
  //	$scope.racesList = [];
  //	$scope.filterName = null;

  //	ergastAPIservice.getRaceWinners().success(function (response) {
  //		//Dig into the response to get the relevante data
  //		$scope.pastRaces = response.MRData.RaceTable.Races;
  //		ergastAPIservice.getRaces().success(function (response) {
  //			$scope.racesList = response.MRData.RaceTable.Races;
  //			angular.forEach($scope.pastRaces, function (race, index) {
  //				//Push each winning driver into raceList
  //				$scope.racesList[index].Results = race.Results;
  //			});
  //		});
  //	});
  //})


  ////RACE CONTROLLER
  //.controller('raceController', function ($scope, $routeParams, $http, ergastAPIservice) {
  //	$scope.id = $routeParams.id;
  //	$scope.raceResult = [];
  //	$scope.qualiResult = [];


  //	ergastAPIservice.getRaceDetails($scope.id).success(function (response) {
  //		$scope.race = response.MRData.RaceTable.Races[0];
  //		$scope.raceResult = response.MRData.RaceTable.Races[0].Results;
  //	});

  //	ergastAPIservice.getQualiDetails($scope.id).success(function (response) {
  //		$scope.qualiResult = response.MRData.RaceTable.Races[0].QualifyingResults;
  //	});

  //	//MOVE THIS SHIT TO A SERVICE
  //	$http.jsonp('http://ergast.com/api/f1/2013/' + $routeParams.id + '/results.json?callback=JSON_CALLBACK').success(function (response) {
  //		$scope.race = response.MRData.RaceTable.Races[0];
  //		$scope.raceResult = response.MRData.RaceTable.Races[0].Results;
  //	}).error(function (error) {
  //	});

  //	//THIS ONE AS WELL< FOR A SEPPARATE SERVICE
  //	$http.jsonp('http://ergast.com/api/f1/2013/' + $routeParams.id + '/qualifying.json?callback=JSON_CALLBACK').success(function (response) {
  //		$scope.qualiResult = response.MRData.RaceTable.Races[0].QualifyingResults;
  //	}).error(function (error) {
  //	});
  //})

  //.controller('menuContr', function ($scope, $location) {
  //	$scope.$on('$routeChangeSuccess', function () {
  //		$scope.menuActive = $location.path().split("/")[1];
  //	});
//})
;