FROM microsoft/dotnet:1.0.1-sdk-projectjson

#RUN dotnet new
WORKDIR /ContactsApi
COPY project.json .
RUN dotnet restore

COPY . .
RUN dotnet publish -c Debug -o out
#RUN dotnet ef migrations add init4
#RUN dotnet ef database update
EXPOSE 5000
#CMD ["dotnet", "run"]
ENTRYPOINT ./run.sh

