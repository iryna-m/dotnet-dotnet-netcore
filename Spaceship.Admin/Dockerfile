FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY Spaceship.Admin/Spaceship.Admin.csproj Spaceship.Admin/
RUN dotnet restore Spaceship.Admin/Spaceship.Admin.csproj
COPY . .
WORKDIR /src/Spaceship.Admin
RUN dotnet build Spaceship.Admin.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Spaceship.Admin.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Spaceship.Admin.dll"]
