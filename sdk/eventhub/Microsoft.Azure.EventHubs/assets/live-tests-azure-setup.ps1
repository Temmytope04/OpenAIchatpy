# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the MIT License.

<#
  .SYNOPSIS
    Performs the tasks needed to setup an Azure subscription for use with the Event Hubs client
    library test suite.

  .DESCRIPTION
    This script handles creation and configuration of needed resources within an Azure subscription
    for use with the Event Hubs client library's Live test suite.  
    
    Upon completion, the script will output a set of environment variables with sensitive information which
    are used for testing.  When running Live tests, please be sure to have these environment variables available,
    either within Visual Studio or command line environment.
 
    For more detailed help, please use the -Help switch. 
#>

# =======================
# == Script Parameters ==
# =======================

[CmdletBinding(DefaultParameterSetName="Help")] 
[OutputType([String])] 
param
( 
  [Parameter(Mandatory=$true, ParameterSetName="Help", Position=0)]
  [Switch] $Help,

  [Parameter(Mandatory=$true, ParameterSetName="Execute", Position=0)]
  [ValidateNotNullOrEmpty()]
  [string] $SubscriptionName,

  [Parameter(Mandatory=$true, ParameterSetName="Execute")]
  [ValidateNotNullOrEmpty()]
  [string] $ResourceGroupName,

  [Parameter(Mandatory=$true, ParameterSetName="Execute")]
  [ValidateNotNullOrEmpty()]
  [ValidateScript({ $_.Length -ge 6})]
  [string] $StorageAccountName,

  [Parameter(Mandatory=$true, ParameterSetName="Execute")]
  [ValidateNotNullOrEmpty()]
  [ValidateScript({ $_.Length -ge 6})]
  [string] $ServicePrincipalName,

  [Parameter(Mandatory=$true, ParameterSetName="Execute")]
  [AllowNull()]  
  $AzureRegion = $null
)

# =====================
# == Module Imports  ==
# =====================

Import-Module Az.Resources

# ==========================
# == Function Definitions ==
# ==========================

function DisplayHelp
{
  <#
    .SYNOPSIS
      Displays the usage help text.

    .DESCRIPTION
      Displays the help text for usage.

    .OUTPUTS
      Help text for usage to the console window.
  #>

  $indent = "    "

  Write-Host "`n"
  Write-Host "Event Hubs Live Test Environment Setup"
  Write-Host ""
  Write-Host "$($indent)This script handles creation and configuration of needed resources within an Azure subscription"
  Write-Host "$($indent)for use with the Event Hubs client library Live test suite."
  Write-Host ""
  Write-Host "$($indent)Upon completion, the script will output a set of environment variables with sensitive information which"
  Write-Host "$($indent)fare used for testing.  When running Live tests, please be sure to have these environment variables available,"
  Write-Host "$($indent)either within Visual Studio or command line environment."
  Write-Host ""
  Write-Host "$($indent)NOTE: Some of these values, such as the client secret, are difficult to recover; please copy them and keep in a"
  Write-Host "$($indent)safe place."
  Write-Host ""
  Write-Host ""
  Write-Host "$($indent)Available Parameters:"
  Write-Host ""
  Write-Host "$($indent)-Help`t`t`tDisplays this message."
  Write-Host ""

  Write-Host "$($indent)-SubscriptionName`t`tRequired.  The name of the Azure subscription to be used for"
  Write-Host "$($indent)`t`t`t`trunning the Live tests."
  Write-Host ""
    
  Write-Host "$($indent)-ResourceGroupName`t`tThe name of the Azure Resource Group that will contain the resources"
  Write-Host "$($indent)`t`t`t`tused for the tests.  This will be created if it does not exist."
  Write-Host ""

  Write-Host "$($indent)-StorageAccountName`t`tThe name of the Azure Storage account that will be used as durable "
  Write-Host "$($indent)`t`t`t`tstorage for the Event Processor Host series of tests.  This will be created if it does"
  Write-Host "$($indent)`t`t`t`tnot exist."
  Write-Host ""

  Write-Host "$($indent)-ServicePrincipalName`tThe name to use for the service principal that will be"
  Write-Host "$($indent)`t`t`t`tbe created to manage the Event Hub instances dynamically for the tests.  This"
  Write-Host "$($indent)`t`t`t`tprincipal must not already exist."
  Write-Host ""

  Write-Host "$($indent)-AzureRegion`t`tThe Azure region that resources should be created in.  This value should be"
  Write-Host "$($indent)the name of the region, in lowercase, with no spaces.  For example: southcentralus"
  Write-Host ""
  Write-Host "$($indent)`t`t`t`tDefault: South Central US (southcentralus)"
  Write-Host ""  
}

function SelectRandomCharacters
{    
    <#
      .SYNOPSIS
        Selects a number of random characters from a set.
    #>

    param
    (
        [Parameter(Mandatory=$true)]
        [int]$length, 

        [Parameter(Mandatory=$true)]
        [string]$characters
    ) 

    $random = (1..$length | ForEach { Get-Random -Maximum $characters.length })
    return (-join $characters[$random])
}

function GenerateRandomPassword()
{
    <#
      .SYNOPSIS
        Generates a random password that can be assigned to a service principal.
        
      .DESCRIPTION
        The password generated by this function will contain a mix of alpha,
        numeric, and special characters and will vary a small amount in its length.        
    #>

    $baseLength = (Get-Random -Minimum 28 -Maximum 37)      
    $upper = (Get-Random -Minimum 6 -Maximum ([int][Math]::Ceiling($baseLength / 3)))  
    $special = (Get-Random -Minimum 2 -Maximum 3)     
    $lower = ($baseLength - $upper - $special - $special)                                 

    $password = SelectRandomCharacters $lower "abcdefghiklmnoprstuvwxyz"
    $password += SelectRandomCharacters $upper "ABCDEFGHKLMNOPRSTUVWXYZ"
    $password += SelectRandomCharacters $special "1234567890"
    $password += SelectRandomCharacters $special "!$%&/()=?}][{@#*+"

    $scrambled = ($password.ToCharArray()) | Get-Random -Count ($password.Length)
    return (-join $scrambled)
}

function TearDownResources
{
    <#
      .SYNOPSIS
        Cleans up any Azure resoruces created by the script.
        
      .DESCRIPTION
        Responsible for cleaning up any Azure resoruces created 
        by the script in case of failure.
    #>
    
    param
    (
        [Parameter(Mandatory=$true)]
        [bool] $cleanResourceGroup,

        [Parameter(Mandatory=$true)]
        [bool] $cleanStorage
    )
    
    Write-Host("Cleaning up resources that were created:")
    
    if ($cleanStorage)
    {
        try 
        {
            Write-Host "`t...Removing Azure Storage account `"$($AzureStorageName)`""
            Remove-AzStorageAccount -ResourceGroupName "$($ResourceGroupName)" -Name "$($StorageAccountName)" -Force | Out-Null
        }
        catch 
        {
            Write-Error "The Azure Storage account: $($StorageAccountName) could not be removed.  You will need to delete this manually."
            Write-Error ""            
            Write-Error $_.Exception.Message
        }
    }

    if ($cleanResourceGroup)
    {
        try 
        {
            Write-Host "`t...Removing resource group `"$($ResourceGroupName)`""
            Remove-AzResourceGroup -Name "$($ResourceGroupName)" -Force | Out-Null
        }
        catch 
        {
            Write-Error "The resource group: $($ResourceGroupName) could not be removed.  You will need to delete this manually."
            Write-Error ""            
            Write-Error $_.Exception.Message
        }
    }
}

# ====================
# == Script Actions ==
# ====================

if ($Help)
{
  DisplayHelp $Defaults
  exit 0
}

if ([String]::IsNullOrEmpty($AzureRegion))
{
    $AzureRegion = "southcentralus"
}

# Disallow prinicpal names with a space.

if ($ServicePrincipalName.Contains(" "))
{
    Write-Error "The principal name may not contain spaces."
    exit -1
}

# Verify the location is valid for an Event Hubs namespace.

$validLocations = @{}
Get-AzLocation | where { $_.Providers.Contains("Microsoft.EventHub")} | ForEach { $validLocations[$_.Location] = $_.Location }

if (!$validLocations.Contains($AzureRegion))
{
    Write-Error "The Azure region must be one of: `n$($validLocations.Keys -join ", ")`n`n" 
    exit -1
}

# Capture the subscription.  The cmdlet will error if there was no subscription, 
# so no need to validate.

Write-Host ""
Write-Host "Working:"
Write-Host "`t...Requesting subscription"
$subscription = (Get-AzSubscription -SubscriptionName "$($SubscriptionName)" -ErrorAction SilentlyContinue)

if ($subscription -eq $null)
{
    Write-Error "Unable to locate the requested Azure subscription: $($SubscriptionName)"
    exit -1
}

Set-AzContext -SubscriptionId "$($subscription.Id)" -Scope "Process" | Out-Null

# Create the resource group, if needed.

Write-Host "`t...Requesting resource group"

$createResourceGroup = $false
$resourceGroup = (Get-AzResourceGroup -ResourceGroupName "$($ResourceGroupName)" -ErrorAction SilentlyContinue)

if ($resourceGroup -eq $null)
{
    $createResourceGroup = $true
}

if ($createResourceGroup)
{
    Write-Host "`t...Creaating new resource group"
    $resourceGroup = (New-AzResourceGroup -Name "$($ResourceGroupName)" -Location "$($AzureRegion)")
}

if ($resourceGroup -eq $null)
{
    Write-Error "Unable to locate or create the resource goup: $($ResourceGroupName)"
    exit -1
}

# At this point, we may have created a resource, so be safe and allow for removing any
# resoruces created should the script fail.

try 
{
    # Create the Azure Storage account, if needed.

    Write-Host "`t...Requesting Azure Storage account"
    $createStorage = $false
    $storageAccount = (Get-AzStorageAccount  -ResourceGroupName "$($ResourceGroupName)" -Name "$($StorageAccountName)" -ErrorAction SilentlyContinue)

     if ($storageAccount -eq $null)
    {
        $createStorage = $true
    }

     if ($createStorage)
    {
        Write-Host "`t...Creating new Azure Storage account"
        Start-Sleep 1

        $storageAccount = (New-AzStorageAccount -ResourceGroupName "$($ResourceGroupName)" -Name "$($StorageAccountName)" -Location "$($AzureRegion)" -SkuName "Standard_LRS")
    }

     if ($storageAccount -eq $null)
    {
        Write-Error "Unable to locate or create the Azure Storage account: $($StorageAccountName)"
        TearDownResources $createResourceGroup $createStorage  $false
        exit -1
    }

    $storageKey = (Get-AzStorageAccountKey -ResourceGroupName "$($ResourceGroupName)" -Name "$($StorageAccountName)").Value[0]

    # Create the service prinicpal and grant contributor access for management in the resource group.

    Write-Host "`t...Creating new service principal"
    Start-Sleep 1

    $credentials = New-Object Microsoft.Azure.Commands.ActiveDirectory.PSADPasswordCredential -Property @{StartDate=Get-Date; EndDate=Get-Date -Year 2099; Password="$(GenerateRandomPassword)"}            
    $principal = (New-AzADServicePrincipal -DisplayName "$($ServicePrincipalName)" -PasswordCredential $credentials)

    if ($principal -eq $null)
    {
        Write-Error "Unable to create the service principal: $($ServicePrincipalName)"
        TearDownResources $createResourceGroup
        exit -1
    }
    
    Write-Host "`t...Assigning permissions (this will take a moment)"
    Start-Sleep 60

    # The propagation of the identity is non-deterministic.  Attempt to retry once after waiting for another minute if
    # the initial attempt fails.

    try 
    {
        New-AzRoleAssignment -ApplicationId "$($principal.ApplicationId)" -RoleDefinitionName "Contributor" -ResourceGroupName "$($ResourceGroupName)" | Out-Null
    }
    catch 
    {
        Write-Host "`t...Still waiting for identity propagation (this will take a moment)"
        Start-Sleep 60
        New-AzRoleAssignment -ApplicationId "$($principal.ApplicationId)" -RoleDefinitionName "Contributor" -ResourceGroupName "$($ResourceGroupName)" | Out-Null
    }    

    # Write the environment variables

    Write-Host "Done."
    Write-Host ""
    Write-Host ""
    Write-Host "EVENT_HUBS_RESOURCEGROUP=$($ResourceGroupName)"
    Write-Host ""
    Write-Host "EVENT_HUBS_SUBSCRIPTION=$($subscription.SubscriptionId)"
    Write-Host ""
    Write-Host "EVENT_HUBS_TENANT=$($subscription.TenantId)"
    Write-Host ""
    Write-Host "EVENT_HUBS_CLIENT=$($principal.ApplicationId)"
    Write-Host ""
    Write-Host "EVENT_HUBS_SECRET=$($credentials.Password)"
    Write-Host ""
    Write-Host "EVENT_HUBS_STORAGE_CONNECTION_STRING=DefaultEndpointsProtocol=https;AccountName=$($StorageAccountName);AccountKey=$($storageKey);EndpointSuffix=core.windows.net"
    Write-Host ""
}
catch 
{
    Write-Error $_.Exception.Message
    TearDownResources $createResourceGroup $createStorage
    exit -1
}
