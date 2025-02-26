# Byggfas
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o /publish

# Körfas
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "TestRazorApp.dll"]