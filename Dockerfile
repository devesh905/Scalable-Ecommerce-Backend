FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY Ecommerce.API/*.csproj Ecommerce.API/
COPY Ecommerce.Application/*.csproj Ecommerce.Application/
COPY Ecommerce.Domain/*.csproj Ecommerce.Domain/
COPY Ecommerce.Infrastructure/*.csproj Ecommerce.Infrastructure/

RUN dotnet restore Ecommerce.API/Ecommerce.API.csproj

COPY . .

WORKDIR /src/Ecommerce.API
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "Ecommerce.API.dll"]