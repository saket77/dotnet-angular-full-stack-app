FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 1443


FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY ["aspCoreCrud.csproj","./"]
RUN dotnet restore "./aspCoreCrud.csproj"
COPY . .
RUN dotnet build "aspCoreCrud.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "aspCoreCrud.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "aspCoreCrud.dll"]