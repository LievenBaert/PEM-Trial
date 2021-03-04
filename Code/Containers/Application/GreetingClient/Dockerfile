FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /out

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

# copy all project files
COPY ./GreetingClient.csproj ./GreetingClient/
RUN dotnet restore ./GreetingClient/GreetingClient.csproj

# copy rest of files
COPY . ./GreetingClient/
WORKDIR "/src/GreetingClient"

# build project
RUN dotnet build "GreetingClient.csproj" -c Release -o /out/build

# publish project
FROM build AS publish
RUN dotnet publish "GreetingClient.csproj" -c Release -o /out/publish

FROM base AS final
WORKDIR /out
COPY --from=publish /out/publish .
ENTRYPOINT ["dotnet", "GreetingClient.dll"]