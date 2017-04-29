angular.module('PortfolioApp.Controllers', [])

  //MENU CONTROLLER
  .controller('menuController', ['$scope', '$location', function($scope, $location){
      $scope.getClass = function (path) {
          return ($location.path().substr(0, path.length) === path) ? 'active' : '';
      }
  }])

  //HOME CONTROLLER
  .controller('homeController', ['$scope', 'portfolioAPIservice', function ($scope, portfolioAPIservice) {
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
  }])

  //PROJECT CONTROLLER
  .controller('projectController', ['$scope', '$routeParams', 'portfolioAPIservice', function ($scope, $routeParams, portfolioAPIservice) {
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
  }])

  //PROJECTS CONTROLLER
  .controller('projectsController', ['$scope', '$routeParams', 'portfolioAPIservice', function ($scope, $routeParams, portfolioAPIservice) {
  	document.title = "Projects | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.projects = [];

  	portfolioAPIservice.getProjects().then(function (response) {
  		if (response.status === 200) {
  			$scope.projects = response.data;
  		}
  		//TODO: handle failure
  	});
  }])

  //ALBUM CONTROLLER
  .controller('albumController', ['$scope', '$routeParams', 'portfolioAPIservice', function ($scope, $routeParams, portfolioAPIservice) {
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
  }])

  //ALBUMS CONTROLLER
  .controller('albumsController', ['$scope', '$routeParams', 'portfolioAPIservice', function ($scope, $routeParams, portfolioAPIservice) {
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
  }])

  //CONTACT CONTROLLER
  .controller('contactController', ['$scope', 'portfolioAPIservice', '$uibModal', function ($scope, portfolioAPIservice, $uibModal) {
      document.title = "Contact Me | littleraeofsun";

  	//run script after view loaded
  	$scope.$on('$viewContentLoaded', function () {

  	});
  })


;