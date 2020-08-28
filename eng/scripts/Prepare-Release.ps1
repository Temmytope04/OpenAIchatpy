param($package)

$repoRoot = Resolve-Path "$PSScriptRoot/../..";

. ${repoRoot}\eng\common\scripts\SemVer.ps1
. ${repoRoot}\eng\common\scripts\ChangeLog-Operations.ps1

$packageDirectory = Get-ChildItem "$repoRoot/sdk" -Directory -Recurse -Depth 2 -Filter $package
$serviceDirectory = ($packageDirectory).Parent.Name

Write-Host "Source directory $serviceDirectory"

$existing = Invoke-WebRequest "https://api.nuget.org/v3-flatcontainer/$($package.ToLower())/index.json" | ConvertFrom-Json;

$libraryType = "preview";
$latestVersion = "unknown";
foreach ($existingVersion in $existing.versions)
{
    $parsedVersion = [AzureEngSemanticVersion]::new($existingVersion)
    if (!$packageOldSemVer.IsPrerelease)
    {
        $libraryType = "GA"
    }
    $latestVersion = $existingVersion;
}

$latestVersion = $existing.versions[$existing.versions.Count - 1];

Write-Host
Write-Host "Latest released version $latestVersion, library type $libraryType" -ForegroundColor Green

$newVersion = Read-Host -Prompt 'Input the new version' 

$releaseType = "None";
$parsedNewVersion = [AzureEngSemanticVersion]::new($newVersion)
if ($parsedNewVersion.Major -ne $parsedVersion.Major)
{
    $releaseType = "Major"
}
elseif ($parsedNewVersion.Minor -ne $parsedVersion.Minor)
{
    $releaseType = "Minor"
}
elseif ($parsedNewVersion.Patch -ne $parsedVersion.Patch)
{
    $releaseType = "Bugfix"
}
elseif ($parsedNewVersion.IsPrerelease)
{
    $releaseType = "Bugfix"
}

Write-Host
Write-Host "Detected released type $releaseType" -ForegroundColor Green

Write-Host
Write-Host "Updating versions" -ForegroundColor Green

& "$repoRoot\eng\scripts\Update-PkgVersion.ps1" -ServiceDirectory $serviceDirectory -PackageName $package -NewVersionString $newVersion

$date = Get-Date
$month = $date.ToString("MMMM")
if ($date.Day -gt 15)
{
    $month = $date.AddMonths(1).ToString("MMMM")
}
Write-Host
Write-Host "Assuming release is in $month" -ForegroundColor Green

$commonParameter = @("--organization", "https://dev.azure.com/azure-sdk", "-o", "json", "--only-show-errors")

$workItems = az boards query @commonParameter --project Release --wiql "SELECT [ID], [State], [Iteration Path], [Title] FROM WorkItems WHERE [State] <> 'Closed' AND [Iteration Path] under 'Release\2020\$month' AND [Title] contains '.NET'" | ConvertFrom-Json;

$matchedWorkItems = @();

Write-Host
Write-Host "The following issues exist:"
foreach ($item in $workItems)
{
    $id = $item.fields."System.ID";
    $title = $item.fields."System.Title";
    $path = $item.fields."System.IterationPath";
    Write-Host "$id - $path - $title" 
}

$issueId = Read-Host -Prompt 'Input the issue ID'

$fields = @{
    "Permalink usetag"="https://github.com/Azure/azure-sdk-for-net/sdk/$serviceDirectory/$package/README.md";
    "Package Registry Permalink"="https://nuget.org/packages/$package/$newVersion";
    "Library Type"=$libraryType;
    "Release Type"=$releaseType;
    "Version Number"=$newVersion;
}

Write-Host
Write-Host "Going to set the following fields:" -ForegroundColor Green

foreach ($field in $fields.Keys)
{
    Write-Host "    $field = $($fields[$field])"
}

$decision = $Host.UI.PromptForChoice('Updating work item', 'Are you sure you want to proceed?', @('&Yes'; '&No'), 0)

if ($decision -eq 0)
{
    az boards work-item update @commonParameter --id $issueId --state Active > $null
    foreach ($field in $fields.Keys)
    {
        az boards work-item update @commonParameter --id $issueId -f "$field=$($fields[$field])" > $null
    }

    Write-Host "Updated https://dev.azure.com/azure-sdk/Release/_workitems/edit/$issueId"
}

$changeLogEntry = Get-ChangeLogEntry -ChangeLogLocation "$packageDirectory/CHANGELOG.md" -VersionString $newVersion

$githubAnchor = $changeLogEntry.ReleaseTitle.Replace("## ", "").Replace(".", "").Replace("(", "").Replace(")", "").Replace(" ", "-")
Write-Host
Write-Host "Snippet for the centralized CHANGELOG:" -ForegroundColor Green
Write-Host "dotnet add package $package --version $newVersion"
Write-Host "### $package [Changelog](https://github.com/Azure/azure-sdk-for-net/blob/master/sdk/$serviceDirectory/$package/CHANGELOG.md#$githubAnchor)"
$changeLogEntry.ReleaseContent | Write-Host 

