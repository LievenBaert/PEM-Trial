set VERSION=%1
set TAG=%2

    IF "0.0.0" == %VERSION%  (
        echo DEV
    ) ELSE (
        echo PROD
    )

echo Tag is %TAG%