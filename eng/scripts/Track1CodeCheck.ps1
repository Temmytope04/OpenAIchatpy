﻿$ErrorActionPreference = 'Stop'
Set-StrictMode -Version 1
$exitCode = 0

[string[]] $errors = @()

function LogError([string]$message) {
    if ($env:TF_BUILD) {
        Write-Host "##vso[task.logissue type=error]$message"
    }
    Write-Host -f Red "error: $message"
    $script:errors += $message
}

function Invoke-Block([scriptblock]$cmd) {
    $cmd | Out-String | Write-Verbose
    & $cmd

    # Need to check both of these cases for errors as they represent different items
    # - $?: did the powershell script block throw an error
    # - $lastexitcode: did a windows command executed by the script block end in error
    if ((-not $?) -or ($lastexitcode -ne 0)) {
        if ($error -ne $null) {
            Write-Warning $error[0]
        }
        throw "Command failed to execute: $cmd"
    }
}

# helper to turn PSCustomObject into a list of key/value pairs
function Get-ObjectMembers {
    [CmdletBinding()]
    Param(
        [Parameter(Mandatory = $True, ValueFromPipeline = $True)]
        [PSCustomObject]$obj
    )
    $obj | Get-Member -MemberType NoteProperty | ForEach-Object {
        $key = $_.Name
        [PSCustomObject]@{Key = $key; Value = $obj."$key" }
    }
}

try {
    # Get RP Mapping
    $RPMapping = @{ }
    $readmePath = ''
    git clone https://github.com/Azure/azure-rest-api-specs.git ../azure-rest-api-specs
    $folderNames = Get-ChildItem ../azure-rest-api-specs/specification
    $folderNames | ForEach-Object {
        if (Test-Path "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.csharp.md") {
            $readmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.csharp.md"
        }
        elseif (Test-Path "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.md") {
            $readmePath = "../azure-rest-api-specs/specification/$($_.Name)/resource-manager/readme.md"
        } 
        $fileContent = Get-Content $readmePath
        foreach ($item in $fileContent) {
            if (($item -match '\$\(csharp-sdks-folder\)')) {
                $item -match "\/([^/]+)\/"
                $folderName = $matches[0].Substring(1, $matches[0].Length - 2)
                if (($folderName -notmatch "\$") -and (!$RPMapping.ContainsKey($folderName))) {
                    $RPMapping += @{ $folderName = "$($_.Name)" }
                }
            }
        }
    }

    # Get Metadata file path
    $Response = Invoke-WebRequest -URI https://api.github.com/repos/$Env:REPOSITORY_NAME/pulls/$Env:PULLREQUEST_ID/files
    $changeList = $Response.Content | ConvertFrom-Json
    $mataPath = @()
    $rpIndex = @()
    $folderName = @()
    $changeList | ForEach-Object {
        $fileName = $_.filename
        if ($fileName -match 'eng/mgmt/mgmtmetadata') {
            $mataPath += $fileName
        }
    }
    $changeList | ForEach-Object {
        $fileName = $_.filename
        if ($fileName -match 'sdk/') {
            $name = $fileName.substring(4, (($fileName.indexof('/Microsoft') - 4)))
            If ($folderName -notcontains $name) {
                $folderName += $name
            }
        }
    }
    foreach ($item in $folderName) {
        $rpName = $RPMapping.Get_Item($item)
        if ($rpName) {
            If ($rpIndex -notcontains $rpName) {
                $rpIndex += $rpName
            }
        }
        else {
            Write-Output "Can't get proper RP name with folder $item"
        }
        
    }
    $rpIndex | ForEach-Object {
        $path = "eng/mgmt/mgmtmetadata/$_" + "_resource-manager.txt"
        if ($mataPath -notcontains $path) {
            $mataPath += $path
        }
    }

    foreach ($item in $mataPath) {
        $metaData = ''
        try {
            $metaData = Get-Content $item
        }
        catch {
            Write-Warning "Cannot find path $item"
        }

        if ( $metaData -ne '') {
            $commit = ''
            $readme = ''
            [string]$path = Get-Location
            $metaData | ForEach-Object {
                if ($_ -match 'Commit') {
                    $commit = $_.substring($_.length - 40, 40)
                }
                if ($_ -match 'cmd.exe') {
                    $_ -match 'https:[\S]*readme.md'
                    $readme = $matches[0]
                }
            }
            $readme = $readme -replace "blob/[\S]*/specification", "blob/$commit/specification"
            $path = ($path -replace "\\", "/") + "/sdk"
    
            Invoke-Block {
                & npm install -g autorest
            }
    
            Write-Output "Ready to execute: autorest $readme --csharp --version=v2 --reflect-api-versions --csharp-sdks-folder=$path --use:@microsoft.azure/autorest.csharp@2.3.90"
            Invoke-Block {
                & autorest $readme --csharp --version=v2 --reflect-api-versions --csharp-sdks-folder=$path --use:@microsoft.azure/autorest.csharp@2.3.90 
            }
    
            # prevent warning related to EOL differences which triggers an exception for some reason
            & git add -A
            $diffResult = @()
            $diffResult += git -c core.safecrlf=false diff HEAD --name-only --ignore-space-at-eol
            if ($diffResult.Length -gt 1) {
                $exitCode ++
            }
            elseif (($diffResult.Length -eq 1) -And ($diffResult[0] -match 'SdkInfo_')) {
                $changeContent = @()
                $content = git -c core.safecrlf=false diff -U0 HEAD --ignore-space-at-eol $diffResult[0]
                $content[4..($content.Length - 1)] | ForEach-Object {
                    if ($_.StartsWith('+') -or $_.StartsWith('-')) {
                        $changeContent += $_
                    }
                }
                if ($changeContent.Length -ne 11) {
                    $exitCode ++
                }
    
                # metaDataContent doesn't contains 'AutoRestCmdExecuted' part since it can't be verified
                $metaDataContent = @('-      // BEGIN: Code Generation Metadata Section',
                    '-      public static readonly String AutoRestVersion = "v2";',
                    '-      public static readonly String AutoRestBootStrapperVersion = "autorest@2.0.4413";',
                    '-      public static readonly String GithubForkName = "Azure";',
                    '-      public static readonly String GithubBranchName = "master";',
                    '-      public static readonly String GithubCommidId = "{0}";'.Replace('{0}', $commit),
                    '-      public static readonly String CodeGenerationErrors = "";',
                    '-      public static readonly String GithubRepoName = "azure-rest-api-specs";',
                    '-      // END: Code Generation Metadata Section'
                )
                foreach ($metaString in $metaDataContent) {
                    if ($metaString -notin $changeContent) {
                        Write-Output "Diff in" $metaString
                        $exitCode ++
                        break
                    }
                }
            }
            elseif (($diffResult.Length -eq 1) -And ($diffResult[0] -notmatch 'SdkInfo_')) {
                $exitCode ++
            }
    
            if ($exitCode -ne 0) {
                & git -c core.safecrlf=false diff HEAD --ignore-space-at-eol
                Write-Output "Git Diff file is:" 
                $diffResult | ForEach-Object {
                    Write-Output $_
                }
                LogError "Generated code is manually altered, you may need to re-run sdk\<RP Name>\generate.ps1"
            }
        }
        
    }
}
finally {
    Write-Host ""
    Write-Host "Summary:"
    Write-Host ""
    Write-Host "   $($errors.Length) error(s)"
    Write-Host ""

    foreach ($err in $errors) {
        Write-Host -f Red "error : $err"
    }

    if ($errors) {
        exit 1
    }
}
