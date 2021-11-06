#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI.csproj", "src/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI/"]
RUN dotnet restore "src/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Treinamento.Ports.WebAPI/Treinamento.Ports.WebAPI"
RUN dotnet build "Treinamento.Ports.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Treinamento.Ports.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Treinamento.Ports.WebAPI.dll"]