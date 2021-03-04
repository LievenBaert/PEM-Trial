set VERSION="1.0.0"
set TAG=""

if %TAG% == "" goto SET01
goto START

::when no tag is given, we assume it to be the latest
:SET01
    @Echo Setting TAG to latest
    set TAG = latest
goto START

:START

    IF "0.0.0" == %VERSION%  (
        echo setting 0.0.0
    ) ELSE (
        echo setting tag = %TAG%
        )