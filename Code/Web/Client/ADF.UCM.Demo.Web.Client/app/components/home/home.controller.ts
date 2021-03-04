/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';
    class HomeController {
        // @ngInject
        constructor(private $log: angular.ILogService) {
            $log.debug('HomeController initialized');

        }


    }

    angular.module('app').controller('HomeController', HomeController);
}
