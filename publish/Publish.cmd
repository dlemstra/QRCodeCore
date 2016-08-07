@echo off
call "%vs140comntools%vsvars32.bat"

msbuild "..\QRCodeCore.sln" /m /p:Configuration=Release
dotnet test ..\tests\QRCodeCore.Tests\project.json
dotnet pack --output . --no-build --configuration Release --version-suffix alpha3 ..\src\QRCodeCore\project.json

del *.symbols.nupkg
