# Use the official Microsoft SDK image to build the solution
FROM mcr.microsoft.com/dotnet/sdk:latest AS build-env
WORKDIR /app

# Copy the solution file
COPY ["Pimpochki.sln", "./"]

# Copy the main web API project file and restore as distinct layers
COPY ["Pimpochki.Api/Pimpochki.Api.csproj", "Pimpochki.Api/"]
COPY ["Pimpochki.Application/Pimpochki.Application.csproj", "Pimpochki.Application/"]
COPY ["Pimpochki.Domain/Pimpochki.Domain.csproj", "Pimpochki.Domain/"]
COPY ["Pimpochki.Infrastructure/Pimpochki.Infrastructure.csproj", "Pimpochki.Infrastructure/"]

# Restore NuGet packages
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet build "Pimpochki.sln" -c Release -o /app/build

# Publish the application
FROM build-env AS publish
RUN dotnet publish "Pimpochki.Api/Pimpochki.Api.csproj" -c Release -o /app/publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:latest AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pimpochki.Api.dll"]