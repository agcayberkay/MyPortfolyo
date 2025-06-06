# Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Solution veya proje dosyasını kopyala
COPY ./MyPortfolyo/*.csproj ./MyPortfolyo/

# Bağımlılıkları yükle
RUN dotnet restore ./MyPortfolyo/MyPortfolyo.csproj

# Tüm dosyaları kopyala
COPY . .

# Publish işlemi
RUN dotnet publish ./MyPortfolyo/MyPortfolyo.csproj -c Release -o out

# Çalıştırma aşaması
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "MyPortfolyo.dll"]
