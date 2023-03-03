FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DockerNet.API/DockerNet.API.csproj", "DockerNet.API/"]
RUN dotnet restore "DockerNet.API/DockerNet.API.csproj"
COPY . .
WORKDIR "/src/DockerNet.API"
RUN dotnet build "DockerNet.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DockerNet.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DockerNet.API.dll"]
