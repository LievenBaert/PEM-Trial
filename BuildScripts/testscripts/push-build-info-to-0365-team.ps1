# Created by LIBA on 17/03/2017
# push build information to an O365 team
# 
Import-Module Microsoft.PowerShell.Utility

$instance = $args[0]
$environment = $args[1]
$version = $args[2]
$buildName = $args[3]
$buildComment = $args[4]
$buildStatus = $args[5]
$buildUrl = $args[6]

$uri = $args[7]

Write-Host "Instance: $instance"
Write-Host "Environment: $environment"
Write-Host "Version: $version"
Write-Host "BuildName: $buildName"
Write-Host "BuildComment: $buildComment"
Write-Host "BuildStatus: $buildStatus"
Write-Host "BuildUrl: $buildUrl"
Write-Host "URI: $uri"

$body = ConvertTo-Json -Depth 4 @{
    title = "Build Notification of $buildName"
    text = "A build completed for $instance-$environment"
    sections = @(
        @{
            activityTitle = 'Build'
            activitySubtitle = "A TFS build ended with status $buildStatus"
            activityText = "$buildComment"
           # activityImage = 'http://URL' # this value would be a path to a nice image you would like to display in notifications
        },
        @{
            title = 'Details'
            facts = @(
                @{
                name = 'Instance'
                value = $instance
                },
                @{
                name = 'Environment'
                value = $environment
                },
                @{
                name = 'Version'
                value = $version
                }
            )
        }
    )
	    potentialAction = @(@{
            '@context' = $buildUrl
            '@type' = 'ViewAction'
            name = 'View build details'
            target = @($buildUrl)
        })
}


Invoke-RestMethod -uri $uri -Method Post -body $body -ContentType 'application/json'
