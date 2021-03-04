@ECHO ON

set SCRIPTDIR=%~dp0%
set PROJDIR="%1"

@if "%PROJDIR%" == "" goto NO1
@goto START

::=====================================================
:NO1
::=====================================================
@Echo Please add the Project directory as first parameter!
@exit 1

::=====================================================
:START

:: global install is alsorun after restart of TFS build service (every date in the morning)
:: so this step shouldn't take long!!
call "%SCRIPTDIR%installnpm-global.bat"

::=====================================================
cd /D "%PROJDIR%"

:: global install will be run after restart of TFS build service (every date in the morning)
:: call "%SCRIPTDIR%installnpm-global.bat"

call "%SCRIPTDIR%install-js.bat"
call "%SCRIPTDIR%gulpbuild.bat"



::=====================================================
:END
::=====================================================
@exit 0
