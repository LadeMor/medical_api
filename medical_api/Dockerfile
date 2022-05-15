FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["medical_api/medical_api.csproj", "medical_api/"]
RUN dotnet restore "medical_api/medical_api.csproj"
COPY . .
WORKDIR "/src/medical_api"
RUN dotnet build "medical_api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "medical_api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "medical_api.dll"]
