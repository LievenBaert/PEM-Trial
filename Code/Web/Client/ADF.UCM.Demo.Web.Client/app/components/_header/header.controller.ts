/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';

    class HeaderController {
    // @ngInject
    constructor(private $log: angular.ILogService, private $mdSidenav: angular.material.ISidenavService) {
        $log.debug('headerController initialized');
    }


    toggleNavBar(): void {
        this.$mdSidenav('left').toggle();
        };

}

angular.module('app').controller('HeaderController', HeaderController);
} 
