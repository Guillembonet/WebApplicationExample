FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
COPY WebApplicationExample.csproj /src/WebApplicationExample/
RUN dotnet restore ./src/WebApplicationExample/WebApplicationExample.csproj
COPY . /src/WebApplicationExample/
WORKDIR /src/WebApplicationExample

FROM build AS publish
RUN dotnet publish "WebApplicationExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebApplicationExample.dll"]