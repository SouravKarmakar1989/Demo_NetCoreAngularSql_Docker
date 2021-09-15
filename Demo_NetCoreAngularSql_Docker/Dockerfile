#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Demo_NetCoreAngularSql_Docker/Demo_NetCoreAngularSql_Docker.csproj", "Demo_NetCoreAngularSql_Docker/"]
RUN dotnet restore "Demo_NetCoreAngularSql_Docker/Demo_NetCoreAngularSql_Docker.csproj"
COPY . .
WORKDIR "/src/Demo_NetCoreAngularSql_Docker"
RUN dotnet build "Demo_NetCoreAngularSql_Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Demo_NetCoreAngularSql_Docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Demo_NetCoreAngularSql_Docker.dll"]