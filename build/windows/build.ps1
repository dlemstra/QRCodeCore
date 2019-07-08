. $PSScriptRoot\..\..\tools\utils.ps1

function buildSolution($solution, $properties)
{
    $path = fullPath $solution
    $directory = Split-Path -parent $path
    $filename = Split-Path -leaf $path

    $nuget = fullPath "build\windows\nuget.exe"
    & $nuget restore $path
    & $nuget restore $path

    $location = $(Get-Location)
    Set-Location $directory

    msbuild $filename /t:Rebuild ("/p:$($properties)")
    checkExitCode "Failed to build: $($path)"

    Set-Location $location
}

buildSolution "QRCodeCore.sln" "Configuration=Release,Platform=Any CPU"