FROM microsoft/dotnet:3.0-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:3.0-sdk AS build
WORKDIR /src
COPY ["docker.csproj", "./"]
RUN dotnet restore "./docker.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "docker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "docker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "docker.dll"]
