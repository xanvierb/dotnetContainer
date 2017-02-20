FROM microsoft/dotnet:1.0.0-runtime
COPY out .
ENTRYPOINT ["dotnet", "workspace.dll"]
