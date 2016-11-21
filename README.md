# Big Star Dotnet

csharp-kestrel-dotnet example with a small set of runtime dependencies

## Installation Guides

Developed using

[.NET Core installation guide](https://www.microsoft.com/net/core#macos)

[Visual Studio Code](https://code.visualstudio.com/)

## Building

Build using the below

```
dotnet build src/**/project.json
```

## Testing

Build using the below

```
dotnet build test/**/project.json
```

Test using the below

```
dotnet test test/accounts-test; dotnet test test/metrics-test; dotnet test test/bigstar-test
```

## Cleaning

Clean directories using the below

```
find . -type d -name 'bin' -exec rm -r {} +
find . -type d -name 'obj' -exec rm -r {} +
```