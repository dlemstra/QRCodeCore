# Copyright (c) Carbon and contributors.
# Licensed under the MIT License.

function checkExitCode($msg)
{
    if ($LastExitCode -ne 0)
    {
        Write-Error $msg
        Exit 1
    }
}

function fullPath($path)
{
    return "$PSScriptRoot\..\..\$path"
}