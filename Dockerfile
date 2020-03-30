FROM mcr.microsoft.com/dotnet/core/runtime:2.1-alpine3.11
WORKDIR /app
COPY * .
ENTRYPOINT ["dotnet", "Spaceship.Admin.dll"]
