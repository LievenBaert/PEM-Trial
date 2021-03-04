set SCRIPTDIR=%~dp0%

attrib -R  typings\index.d.ts
call "%SCRIPTDIR%\installnpm.bat"
call "%SCRIPTDIR%\installbow.bat"
call "%SCRIPTDIR%\installtypings.bat"
