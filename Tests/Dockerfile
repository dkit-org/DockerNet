FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Tests/Tests.csproj", "Tests/"]
RUN dotnet restore "Tests/Tests.csproj"
COPY . .
WORKDIR "/src/Tests"
RUN dotnet build "Tests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tests.dll"]
