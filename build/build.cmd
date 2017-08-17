@echo off

set solution=QRCodeCore.sln

nuget restore %solution%

msbuild %solution% /m:4 /t:Rebuild /p:Configuration=Release;codecov=true