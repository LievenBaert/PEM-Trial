set SCRIPTDIR=%~dp0%
set PROJDIR="%1"
set VERSION=%2
set TAG=%3

if "%PROJDIR%" == "" goto NO1
goto START
if "%VERSION%" == "" goto NO2
goto START
::=====================================================
:NO1
::=====================================================
@Echo Please add Project directory as first parameter!
ex::=====================================================
:NO2
::=====================================================
@Echo Please add Version info as second parameter!
exit 1
::=====================================================
:START
::=====================================================

:: check if all tooling is present
call "%SCRIPTDIR%\installnpm-global.bat"
IF ERRORLEVEL 1 ( 
      ECHO error level is 1 or more for installnpm-global 
      EXIT /B 0
    ) 
echo switching to project directory %PROJDIR%
cd /D "%PROJDIR%"


::the upgrade script should not upgrade the dependent arcelor pacakages to the same version
:: if this package is not part of the arcelor mittal central packages.
Echo Setting Version to %VERSION%, not touching dependencies
ATTRIB -R  package.json

call "%SCRIPTDIR%UpgradeVersionNG2\UpgradeVersion.exe" "package.json" %VERSION% "NotFramework"
IF ERRORLEVEL 1 (
         Set BUILDERROR = ERRORLEVEL
     ECHO error level is 1 or more for UpgradeVersion.exe %VERSION%
    EXIT -1
    )

    echo %SKIPINSTALL%
IF "%SKIPINSTALL%" == "1" echo skipping install...
IF "%SKIPINSTALL%" == "1" GOTO :END 
    echo calling npm install

    IF "0.0.0" == %VERSION%  (
        call "%SCRIPTDIR%\installnpm.bat"
    ) ELSE (
        call "%SCRIPTDIR%\installnpm.bat"
    )    
    
    IF ERRORLEVEL 1 (
        ECHO error level is 1 or more for installnpm 
        EXIT /B ERRORLEVEL
        ) 
    
    call "%SCRIPTDIR%\publishnpmpackage.bat" %VERSION%  %TAG%
    IF ERRORLEVEL 1 (
            Set BUILDERROR = ERRORLEVEL
        ECHO error level is 1 or more for publishnpmpackage 
        EXIT -1
        ) 
)  
:END  
:: webpack by convention makes a dist folder, we want to capture a public folder
:: throws a error when neither exists before
call "%SCRIPTDIR%\CopyFolder\CopyFolder.exe"

ATTRIB +R  package.json
EXIT /B 0




