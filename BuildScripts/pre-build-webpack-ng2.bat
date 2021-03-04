set SCRIPTDIR=%~dp0%
set PROJDIR="%1"
set VERSION="%2"
if "%PROJDIR%" == "" goto NO1

if "%VERSION%" == "" (
    set VERSION ="SEM-VER-NULL"
)

goto START

::=====================================================
:NO1
::=====================================================
@Echo Please add Project directory as first parameter!
exit 1

::=====================================================
:START
::=====================================================
cd /D %PROJDIR%

:: global install is alsorun after restart of TFS build service (every date in the morning)
:: so this step shouldn't take long!!
call "%SCRIPTDIR%installnpm-global.bat"

    IF "0.0.0" == %VERSION%  (
        call "%SCRIPTDIR%\installnpmdev.bat"
    ) ELSE (
        call "%SCRIPTDIR%\installnpm.bat"
    ) 

call "%SCRIPTDIR%\webpackbuild-ng2.bat"

:: webpack by convention makes a dist folder, we want to capture a public folder
:: throws a error when neither exists before
call "%SCRIPTDIR%\CopyFolder\CopyFolder.exe"
::=====================================================
:END
::=====================================================
exit 0
