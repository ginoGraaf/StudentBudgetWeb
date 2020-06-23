FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

COPY *.sln .
COPY Rest/*.csproj ./Rest/
COPY DataAccessLibrary/*.csproj ./DataAccessLibrary/
RUN dotnet restore

COPY . ./
RUN dotnet test
WORKDIR /app/Rest
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY --from=build-env /app/Rest/out ./
EXPOSE 80
RUN apt update
RUN apt install openconnect -y
ENTRYPOINT ["dotnet","Rest.dll"]
