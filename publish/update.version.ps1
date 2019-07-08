param (
    [parameter(mandatory=$true)][string]$version
)

. $PSScriptRoot\..\tools\utils.ps1

function setValue($content, $startMatch, $endMatch, $value) {
  $start = $content.IndexOf($startMatch)
  if ($start -eq -1) {
    Write-Error "Unable to find startMatch"
    Exit 1
  }

  $start += $startMatch.Length

  $newContent = $content.Substring(0, $start)
  $newContent += $value

  $start = $content.IndexOf($endMatch, $start)
  if ($start -eq -1) {
    Write-Error "Unable to find endMatch"
    Exit 1
  }

  $newContent += $content.Substring($start)
  return $newContent
}

function updateAssemblyVersion($library, $version) {
    $fileName = fullPath "src\$library\$library.csproj"
    $content = [IO.File]::ReadAllText($fileName, [System.Text.Encoding]::Default)

    $assemblyVersion = $version.Substring(0, $version.LastIndexOf(".") + 1) + "0"

    $content = setValue $content "`<AssemblyVersion>" "`<" $assemblyVersion
    $content = setValue $content "`<FileVersion`>" "`<" $version
    [IO.File]::WriteAllText($fileName, $content, [System.Text.Encoding]::Default)
}

function updateNuspec($library, $version) {
    $fileName = fullPath "publish\$library.nuspec"
    $content = [IO.File]::ReadAllText($fileName, [System.Text.Encoding]::Default)

    $assemblyVersion = $version.Substring(0, $version.LastIndexOf(".") + 1) + "0"

    $content = setValue $content "`<version`>" "`<" $version
    $content = setValue $content "`<copyright`>" "`<" "Copyright 2016-$((Get-Date).year) Dirk Lemstra"
    [IO.File]::WriteAllText($fileName, $content, [System.Text.Encoding]::Default)
}

updateAssemblyVersion "QRCodeCore" $version
updateNuspec "QRCodeCore" $version
