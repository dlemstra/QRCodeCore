@echo off
call "init.visualstudio.cmd"

powershell .\build.ps1
if %errorlevel% neq 0 exit /b %errorlevel%