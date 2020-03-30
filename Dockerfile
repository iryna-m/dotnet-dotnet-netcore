FROM mcr.microsoft.com/dotnet/core/runtime:2.1-alpine3.11
WORKDIR /app
COPY /Spaceship.Admin/bin/Debug/netcoreapp2.0/Spaceship.Admin.dll .
ENTRYPOINT ["dotnet", "Spaceship.Admin.dll"]
