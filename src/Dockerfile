FROM mcr.microsoft.com/dotnet/sdk:latest AS build-env
WORKDIR /app

COPY ["Pimpochki.sln", "./"]

COPY ["Pimpochki.Api/Pimpochki.Api.csproj", "Pimpochki.Api/"]
COPY ["Pimpochki.Application/Pimpochki.Application.csproj", "Pimpochki.Application/"]
COPY ["Pimpochki.Domain/Pimpochki.Domain.csproj", "Pimpochki.Domain/"]
COPY ["Pimpochki.Infrastructure/Pimpochki.Infrastructure.csproj", "Pimpochki.Infrastructure/"]

RUN dotnet restore

COPY . .
RUN dotnet build "Pimpochki.sln" -c Release -o /app/build

FROM build-env AS publish
RUN dotnet publish "Pimpochki.Api/Pimpochki.Api.csproj" -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:latest AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Pimpochki.Api.dll"]