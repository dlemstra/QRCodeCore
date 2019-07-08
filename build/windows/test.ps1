. $PSScriptRoot\..\..\tools\utils.ps1

function runTests($targetFramework)
{
    $vstest = "$($env:VSINSTALLDIR)\Common7\IDE\Extensions\TestPlatform\vstest.console.exe"

    $folder = fullPath "tests\QRCodeCore.Tests\bin\Release\$targetFramework"
    $fileName = "$folder\QRCodeCore.Tests.dll"

    & $vstest $fileName

    checkExitCode("Failed to test QRCodeCore")
}

runTests "netcoreapp2.0"
runTests "net461"