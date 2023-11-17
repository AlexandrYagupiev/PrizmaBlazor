FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/TMS.IdentityServer.STS.Identity/TMS.IdentityServer.STS.Identity.csproj", "src/TMS.IdentityServer.STS.Identity/"]
COPY ["src/TMS.IdentityServer.Admin.EntityFramework.Shared/TMS.IdentityServer.Admin.EntityFramework.Shared.csproj", "src/TMS.IdentityServer.Admin.EntityFramework.Shared/"]
COPY ["src/TMS.IdentityServer.Shared/TMS.IdentityServer.Shared.csproj", "src/TMS.IdentityServer.Shared/"]
RUN dotnet restore "src/TMS.IdentityServer.STS.Identity/TMS.IdentityServer.STS.Identity.csproj"
COPY . .
WORKDIR "/src/src/TMS.IdentityServer.STS.Identity"
RUN dotnet build "TMS.IdentityServer.STS.Identity.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TMS.IdentityServer.STS.Identity.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "TMS.IdentityServer.STS.Identity.dll"]