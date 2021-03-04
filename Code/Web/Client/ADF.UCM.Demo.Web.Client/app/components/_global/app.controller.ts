/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';

    class GlobalController {
        
        /* @ngInject */
        constructor(private $log: angular.ILogService) {
            $log.debug('GlobalController initialized');
        }
    }
    
    angular.module('app').controller('GlobalController', GlobalController);
}
