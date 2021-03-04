
::typescript check for tsc instead of
where /Q tsc.cmd
IF %ERRORLEVEL% == 1 (
        npm install typescript -g
        echo typescript installed
)ELSE ( echo typescript ok)



:: do something cool, then log it
CALL :INSTALL "npm-cache"
CALL :INSTALL "bower"
CALL :INSTALL "typings"
CALL :INSTALL "tslint"
CALL :INSTALL "rimraf"
CALL :INSTALL "gulp"
CALL :INSTALL "webpack"
CALL :INSTALL "yarn"
:: force execution to quit at the end of the "main" logic
@EXIT /B ERRORLEVEL

:: a function to write to a log file and write to stdout
:INSTALL
where /Q %1
IF %ERRORLEVEL% == 1 (
        npm install %1 -g
        echo %1 installed
)ELSE ( echo %1 ok)
@EXIT /B 0