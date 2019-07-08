& cmd /c 'git describe --exact-match --tags HEAD > tag.txt 2> nul'

$tag = [IO.File]::ReadAllText("tag.txt").Trim()

if ($tag.Length -gt 0) {
    Write-Host "##vso[build.updatebuildnumber]$tag"
}

Exit 0
