FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Hackathon.Fiap.Grupo02.Worker/Hackathon.Fiap.Grupo02.Worker.csproj", "Hackathon.Fiap.Grupo02.Worker/"]
RUN dotnet restore "Hackathon.Fiap.Grupo02.Worker/Hackathon.Fiap.Grupo02.Worker.csproj"
COPY . .
WORKDIR "/src/Hackathon.Fiap.Grupo02.Worker"
RUN dotnet build "Hackathon.Fiap.Grupo02.Worker.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Hackathon.Fiap.Grupo02.Worker.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hackathon.Fiap.Grupo02.Worker.dll"]
