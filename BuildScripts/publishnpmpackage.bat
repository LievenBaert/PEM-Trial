set VERSION=%1
set TAG=%2

if "%TAG%" == "" goto SET01
goto START

::when no tag is given, we assume it to be the latest
:SET01
    @Echo Setting TAG to latest
    set TAG=latest
goto START

:START

    IF "0.0.0" == %VERSION%  (
        :: Publish to dev channel
        npm publish --registry=http:\\packagefeeds.sidmar.be:81\npm\NpmDev
        npm publish --tag alpha
    ) ELSE (
        npm publish --tag "%TAG%"
    )