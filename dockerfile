FROM microsoft/dotnet:runtime
COPY out .
ENTRYPOINT ["dotnet", "run"]