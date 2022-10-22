FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
EXPOSE 80
ENV ASPNETCORE_URLS=http://+:80 
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CostAccountingAPI.csproj", "CostAccountingAPI.csproj"]
RUN dotnet restore "CostAccountingAPI.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "CostAccountingAPI.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CostAccountingAPI.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CostAccountingAPI.dll"]