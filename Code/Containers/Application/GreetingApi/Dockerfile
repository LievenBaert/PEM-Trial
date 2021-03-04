FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /out

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src

# copy all project files
COPY ./GreetingApi.csproj ./GreetingApi/
RUN dotnet restore ./GreetingApi/GreetingApi.csproj
# copy rest of files
COPY . ./GreetingApi/
WORKDIR "/src/GreetingApi"

# build project
RUN dotnet build "GreetingApi.csproj" -c Release -o /out/build

# publish project
FROM build AS publish
RUN dotnet publish "GreetingApi.csproj" -c Release -o /out/publish

FROM base AS final
WORKDIR /out
COPY --from=publish /out/publish .
ENTRYPOINT ["dotnet", "GreetingApi.dll"]