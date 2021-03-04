set SCRIPTDIR=%~dp0%
set PROJDIR="%1"
set VERSION=%2
set TAG=%3

if "%PROJDIR%" == "" goto NO1
goto START
if "%VERSION%" == "" goto NO2
goto START
if "%TAG%" == "" goto NO3
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
:NO3
::=====================================================
@Echo No Tag given, this package will be published as the latest
::exit 1
::=====================================================
:START
::=====================================================

:: check if all tooling is present
ECHO TIMING: %PROJDIR%
ECHO TIMING : npm install global START %Time%
call "%SCRIPTDIR%\installnpm-global.bat"
ECHO TIMING: npm install global END %Time%
IF ERRORLEVEL 1 ( 
      ECHO error level is 1 or more for installnpm-global 
      EXIT /B 0
    ) 
echo switching to project directory %PROJDIR%
cd /D "%PROJDIR%"


Echo Setting Version to %VERSION%
ATTRIB -R  package.json
ECHO TIMING: upgrade version START %Time%
call "%SCRIPTDIR%UpgradeVersion\UpgradeVersion.exe" %VERSION%
Echo Setting Version to %VERSION%
ECHO TIMING: upgrade version END %Time%
IF ERRORLEVEL 1 (
         ATTRIB +R  package.json
         Set BUILDERROR = ERRORLEVEL
     ECHO error level is 1 or more for UpgradeVersion.exe %VERSION%
    EXIT -1
    )
ATTRIB +R  package.json    
    echo %SKIPINSTALL%
IF "%SKIPINSTALL%" == "1" echo skipping install...
IF "%SKIPINSTALL%" == "1" GOTO :END 



    echo calling npm install
	ECHO TIMING: npm install START %Time%
    IF "0.0.0" == %VERSION%  (
        call "%SCRIPTDIR%\installnpmdev.bat"
    ) ELSE (
        call "%SCRIPTDIR%\installnpm.bat"
    )    
	ECHO TIMING: npm install END %Time%
    
    IF ERRORLEVEL 1 (
        ECHO error level is 1 or more for installnpm 
        EXIT /B ERRORLEVEL
        ) 

    echo build npm package
	ECHO TIMING: build prod START %Time%
    call "%SCRIPTDIR%\buildnpmpackage.bat" 
	ECHO TIMING: build prod END %Time%
    IF ERRORLEVEL 1 (
            Set BUILDERROR = ERRORLEVEL
        ECHO error level is 1 or more for buildnpmpackage 
        EXIT -1
        ) 
	ECHO TIMING: npm publish START %Time%
    call "%SCRIPTDIR%\publishnpmpackage.bat" %VERSION% %TAG%
	ECHO TIMING: npm publish END %Time%
    IF ERRORLEVEL 1 (
            Set BUILDERROR = ERRORLEVEL
        ECHO error level is 1 or more for publishnpmpackage 
        EXIT -1
        ) 
)  
:: webpack by convention makes a dist folder, we want to capture a public folder
:: throws a error when neither exists before
call "%SCRIPTDIR%\CopyFolder\CopyFolder.exe"

:END  

EXIT /B 0




