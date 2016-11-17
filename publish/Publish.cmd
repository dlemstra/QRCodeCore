@echo off
call "%vs140comntools%vsvars32.bat"

msbuild "..\QRCodeCore.sln" /m /p:Configuration=Release
if %ERRORLEVEL% neq 0 goto failed

dotnet test ..\tests\QRCodeCore.Tests\project.json
if %ERRORLEVEL% neq 0 goto failed

dotnet pack --output . --no-build --configuration Release --version-suffix alpha4 ..\src\QRCodeCore\project.json
if %ERRORLEVEL% neq 0 goto failed

del *.symbols.nupkg

goto done:

:failed:
pause

:done