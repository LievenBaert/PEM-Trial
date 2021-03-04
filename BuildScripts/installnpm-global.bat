@set SCRIPTDIR=%~dp0%

@echo ==== Install npm global ====

:RC
    xcopy %SCRIPTDIR%*.*rc %userprofile% /q /y

    @if not exist "d:\_builds\" @goto :CONFIG

    @echo Override rc-file to store cache on d-drive...
    xcopy "%SCRIPTDIR%.npmrc_d-drive" "%userprofile%\.npmrc" /q /y
    xcopy "%SCRIPTDIR%.bowerrc_d-drive" "%userprofile%\.bowerrc" /q /y

    @goto :CONFIG

:CONFIG
    xcopy %SCRIPTDIR%.gitconfig %userprofile% /q /y

    @goto :TOOLS

:TOOLS
    call "%SCRIPTDIR%findtools.bat"
    @goto :END

:END
    @echo ==== Global npm install done ====
