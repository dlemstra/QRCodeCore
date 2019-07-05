#!/bin/bash
set -e

dotnet build QRCodeCore.Tests.csproj -f netcoreapp2.0 -c Release
dotnet test QRCodeCore.Tests.csproj -f netcoreapp2.0 -c Release
