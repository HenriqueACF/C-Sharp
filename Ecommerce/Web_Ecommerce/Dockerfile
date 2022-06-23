FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Web_Ecommerce/Web_Ecommerce.csproj", "Web_Ecommerce/"]
RUN dotnet restore "Web_Ecommerce/Web_Ecommerce.csproj"
COPY . .
WORKDIR "/src/Web_Ecommerce"
RUN dotnet build "Web_Ecommerce.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Web_Ecommerce.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Web_Ecommerce.dll"]
