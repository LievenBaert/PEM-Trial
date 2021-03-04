@ECHO on

pushd %~dp0

SET currentDirectory=%~dp0
SET scriptPath="%currentDirectory%push-build-info-to-0365-team.ps1"

PowerShell -NoProfile -ExecutionPolicy Bypass -Command "& '%scriptPath%' '%1' '%2' '%3' '%4' '%5' '%6' '%7' '%8'"

popd
