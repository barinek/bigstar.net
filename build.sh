#!/bin/sh

set -e

find . -type d -name 'bin' -exec rm -r {} +
find . -type d -name 'obj' -exec rm -r {} +

dotnet restore src/**/project.json
dotnet build src/**/project.json

dotnet restore test/**/project.json
dotnet build test/**/project.json

dotnet test test/accounts-test
dotnet test test/metrics-test
dotnet test test/bigstar-test