/* for more info about the template, visit http://wiki.sidmar.be/ArcelorMittal_Angular_Template */
namespace app {
    'use strict';


    /**
     * Toggle debug info data (better disabled in production environments)
     * https://docs.angularjs.org/guide/production
     */
    // @ngInject
    function initDebug($compileProvider: angular.ICompileProvider): void {
        $compileProvider.debugInfoEnabled(true);
    }

    angular
        .module('app')
        .config(initDebug);
}