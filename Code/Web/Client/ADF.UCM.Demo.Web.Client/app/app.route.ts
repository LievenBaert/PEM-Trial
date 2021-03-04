/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';

    /**
     * Initialize the router's default behaviors
     */
    // @ngInject
    function initRouter($urlRouterProvider: angular.ui.IUrlRouterProvider,
                        $stateProvider: angular.ui.IStateProvider): void {

        $urlRouterProvider.otherwise('/');

        $stateProvider
            .state('app', {
                abstract: true,
                views: {
                    'header': {
                        templateUrl: 'app/components/_header/header.html',
                        controller: 'HeaderController',
                        controllerAs: 'vm'
                    },
                    'footer': {
                        templateUrl: 'app/components/_footer/footer.html',
                        controller: 'FooterController',
                        controllerAs: 'vm'
                    },
                    'sidebar': {
                        templateUrl: 'app/components/_sidebar/sidebar.html',
                        controller: 'SidebarController',
                        controllerAs: 'vm'
                    }
                }
            })
            .state('app.home', {
                url: '/',
                views: {
                    'main@': {
                        templateUrl: 'app/components/home/home.html',
                        controller: 'HomeController',
                        controllerAs: 'vm'
                    }
                }
            });
    }

    angular.module('app').config(initRouter);
}  