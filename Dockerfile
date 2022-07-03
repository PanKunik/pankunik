FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY src/BlazorUI/BlazorUI.csproj .
RUN dotnet restore BlazorUI.csproj
COPY src/BlazorUI .
RUN dotnet build BlazorUI.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish BlazorUI.csproj -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
