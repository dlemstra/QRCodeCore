@echo off
call "init.visualstudio.cmd"

powershell .\test.ps1
if %errorlevel% neq 0 exit /b %errorlevel%