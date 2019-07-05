Write-Host "Installing NuGet"
$sourceNugetExe = "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe"
$targetNugetExe = "$PSScriptRoot\nuget.exe"
Invoke-WebRequest $sourceNugetExe -OutFile $targetNugetExe