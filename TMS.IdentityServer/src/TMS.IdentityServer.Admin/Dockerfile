FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TMS.IdentityServer.Admin/TMS.IdentityServer.Admin.csproj", "src/TMS.IdentityServer.Admin/"]
COPY ["src/TMS.IdentityServer.Admin.EntityFramework.Shared/TMS.IdentityServer.Admin.EntityFramework.Shared.csproj", "src/TMS.IdentityServer.Admin.EntityFramework.Shared/"]
COPY ["src/TMS.IdentityServer.Admin.EntityFramework.SqlServer/TMS.IdentityServer.Admin.EntityFramework.SqlServer.csproj", "src/TMS.IdentityServer.Admin.EntityFramework.SqlServer/"]
COPY ["src/TMS.IdentityServer.Shared/TMS.IdentityServer.Shared.csproj", "src/TMS.IdentityServer.Shared/"]
COPY ["src/TMS.IdentityServer.Admin.EntityFramework.PostgreSQL/TMS.IdentityServer.Admin.EntityFramework.PostgreSQL.csproj", "src/TMS.IdentityServer.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/TMS.IdentityServer.Admin.EntityFramework.MySql/TMS.IdentityServer.Admin.EntityFramework.MySql.csproj", "src/TMS.IdentityServer.Admin.EntityFramework.MySql/"]
RUN dotnet restore "src/TMS.IdentityServer.Admin/TMS.IdentityServer.Admin.csproj"
COPY . .
WORKDIR "/src/src/TMS.IdentityServer.Admin"
RUN dotnet build "TMS.IdentityServer.Admin.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TMS.IdentityServer.Admin.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TMS.IdentityServer.Admin.dll"]