#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Hackaton.Fiap.Grupo02.API/Hackaton.Fiap.Grupo02.Api.csproj", "Hackaton.Fiap.Grupo02.Api/"]
RUN dotnet restore "./Hackaton.Fiap.Grupo02.API/Hackaton.Fiap.Grupo02.API.csproj"
COPY . .
WORKDIR "/src/Hackaton.Fiap.Grupo02.Api"
RUN dotnet build "./Hackaton.Fiap.Grupo02.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Hackaton.Fiap.Grupo02.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hackaton.Fiap.Grupo02.Api.dll"]