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
::=====================================================
cd /D "%PROJDIR%"

call "%SCRIPTDIR%install.bat"
call "%SCRIPTDIR%gulpbuild.bat"
::call "%SCRIPTDIR%cleanup-modules.bat"

::=====================================================
:END
::=====================================================
@exit 0
