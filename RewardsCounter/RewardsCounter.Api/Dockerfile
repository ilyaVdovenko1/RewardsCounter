FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["RewardsCounter.Api/RewardsCounter.Api.csproj", "RewardsCounter.Api/"]
RUN dotnet restore "RewardsCounter.Api/RewardsCounter.Api.csproj"
COPY . .
WORKDIR "/src/RewardsCounter.Api"
RUN dotnet build "RewardsCounter.Api.csproj" -o /app/build

RUN dotnet tool install -g dotnet-ef
ENV PATH $PATH:/root/.dotnet/tools



FROM build AS publish
RUN dotnet publish "RewardsCounter.Api.csproj" -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RewardsCounter.Api.dll"]
