/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';

    class SidebarController {
    // @ngInject
    constructor(private $log: angular.ILogService) {
        $log.debug('SidebarController initialized');
    }


}

angular.module('app.controllers').controller('SidebarController', SidebarController);
} 