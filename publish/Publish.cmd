@echo off
call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\Tools\VsDevCmd.bat"

set solution=..\QRCodeCore.sln

nuget restore %solution%

msbuild %solution% /m:4 /t:Rebuild /p:Configuration=Release
if %errorlevel% neq 0 goto done

cd ..\tests\QRCodeCore.Tests\

dotnet test --no-build -c Release
if %errorlevel% neq 0 goto done

cd ..\..\Publish

set projectdir=..\src\QRCodeCore

msbuild %projectdir%\QRCodeCore.csproj /m:4 /t:Pack /p:Configuration=Release
if %errorlevel% neq 0 goto done

copy %projectdir%\bin\Release\*.nupkg .

:done

pause