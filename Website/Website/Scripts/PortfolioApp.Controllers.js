angular.module('PortfolioApp.Controllers', ['ui.bootstrap'])

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
  .controller('projectController', ['$scope', '$routeParams', '$location', 'portfolioAPIservice', function ($scope, $routeParams, $location, portfolioAPIservice) {
  	document.title = "Project Title | littleraeofsun";
  	$scope.id = $routeParams.id;
  	$scope.project = null;
  	$scope.previous = null;
  	$scope.next = null;

  	portfolioAPIservice.getProject($scope.id).then(function (response) {
  	    if (response.status === 200) {
  	        if (!response.data.project) {
  	            $location.path('/projects'); //no project exists with this project id
  	        }
  	        else {
  	            document.title = response.data.project.Title + " | littleraeofsun";
  	            $scope.project = response.data.project;
  	            if (response.data.previous.length > 0) {
  	                $scope.previous = response.data.previous[0];
  	            }
  	            if (response.data.next.length > 0) {
  	                $scope.next = response.data.next[0];
  	            }

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

      var $ctrl = this;
      $ctrl.animationsEnabled = true;

      $scope.showEmail = function () {
          portfolioAPIservice.getEmail().then(function (response) {
              if (response.status === 200) {
                  $scope.email = response.data;
                  var modalInstance = $uibModal.open({
                      animation: $ctrl.animationsEnabled,
                      ariaLabelledBy: 'modal-title',
                      ariaDescribedBy: 'modal-body',
                      templateUrl: 'partials/emailModal.html',
                      controller: 'contactEmailController',
                      size: 'sm',
                      controllerAs: '$ctrl',
                      resolve: {
                          email: function () {
                              return $scope.email;
                          }
                      }
                  });

                  modalInstance.result.then(function () {
                      //$log.info('Modal dismissed at: ' + new Date());
                  });
              }
          });
      }

  	//run script after view loaded
  	$scope.$on('$viewContentLoaded', function () {

  	});
  }])

  .controller('contactEmailController', ['$scope', '$uibModalInstance', 'email', function ($scope, $uibModalInstance, email) {
      var $ctrl = this;
      $scope.email = email;

      $scope.selectText = function () {
          $('#ContactEmail').select().focus();
      }      

      $ctrl.ok = function () {
          $uibModalInstance.close();
      };
  }])
;