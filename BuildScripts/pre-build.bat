@ECHO ON
echo Starting build script
set SCRIPTDIR=%~dp0%
set PROJDIR="%1"

SET "PATH=%PATH%;%APPDATA%\npm;"
@if "%PROJDIR%" == "" goto NO1
@goto START

::=====================================================
:NO1
::=====================================================
@Echo Please add the Project directory as first parameter!
@exit 1

::=====================================================
:START
::=====================================================
cd /D "%PROJDIR%"

:: global install is alsorun after restart of TFS build service (every date in the morning)
:: so this step shouldn't take long!!
call "%SCRIPTDIR%installnpm-global.bat"

:: installing the local packages
call "%SCRIPTDIR%install.bat"

:: executing the gulp build 
call "%SCRIPTDIR%gulpbuild.bat"


::=====================================================
:END
::=====================================================
@exit 0
