/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';
    class FooterController {
        // @ngInject
        constructor(private $log: angular.ILogService, private toastService: ICustomToastService) {
            $log.debug('footerController initialized');

            toastService.show('hi');
        }


    }

    angular.module('app').controller('FooterController', FooterController);
} 
