# Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Proje dosyasını kopyala ve bağımlılıkları yükle
COPY *.csproj ./
RUN dotnet restore

# Tüm dosyaları kopyala ve yayınla
COPY . ./
RUN dotnet publish -c Release -o out

# Çalışma aşaması
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

# Uygulamayı başlat
ENTRYPOINT ["dotnet", "MyPortfolyo.dll"]
