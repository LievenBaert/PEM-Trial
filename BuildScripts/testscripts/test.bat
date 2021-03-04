set SCRIPTDIR=%~dp0%
set PROJDIR="%1"
set VERSION=%2
set TAG=%3

if %TAG% == "" GOTO :SETLATEST
GOTO :START

::when no tag is given, we assume it to be the latest
:SETLATEST
set TAG = latest
GOTO :START

:START

    call "%SCRIPTDIR%\testcall.bat" %VERSION%  %TAG%