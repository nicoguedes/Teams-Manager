FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Team-Manager-API/Team-Manager-API.csproj", "Team-Manager-API/"]
RUN dotnet restore "Team-Manager-API/Team-Manager-API.csproj"
COPY . .
WORKDIR "/src/Team-Manager-API"
RUN dotnet build "Team-Manager-API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Team-Manager-API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Team-Manager-API.dll"]