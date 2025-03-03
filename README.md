# OcelotApiGatewayDemo

This project is an example application that includes an API Gateway using Ocelot and two microservices (CarService and UserService). The project is developed on .NET 9.0.

## Project Structure

```
OcelotApiGatewayDemo/
│
├── ApiGateway/
│   ├── ApiGateway.csproj
│   ├── ApiGateway.http
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── ocelot.json
│   ├── Program.cs
│   └── Controllers/
│
├── CarService/
│   ├── CarService.csproj
│   ├── CarService.http
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Controllers/
│   ├── Mappings/
│   └── Models/
│
├── UserService/
│   ├── UserService.csproj
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Controllers/
│   ├── Mappings/
│   └── Models/
│
└── OcelotApiGatewayDemo.sln
```

## Installation

### Requirements

- .NET 9.0 SDK
- Visual Studio or Visual Studio Code

### Steps

1. Clone this repository:

```sh
git clone https://github.com/username/OcelotApiGatewayDemo.git
cd OcelotApiGatewayDemo
```

2. Restore required NuGet packages:

```sh
dotnet restore
```

3. Build the project:

```sh
dotnet build
```

## Running the Application

### Running the API Gateway

```sh
cd ApiGateway
dotnet run
```

### Running CarService

```sh
cd CarService
dotnet run
```

### Running UserService

```sh
cd UserService
dotnet run
```

## Configuration

### Ocelot Configuration

Ocelot configuration is located in the [`ApiGateway/ocelot.json`](ApiGateway/ocelot.json) file. This file contains routing rules and other settings for the API Gateway.

### Application Settings

Each service has its own application settings in `appsettings.json` and `appsettings.Development.json`.

## Usage

### API Requests

You can test API requests using `*.http` files. For example, use [`ApiGateway/ApiGateway.http`](ApiGateway/ApiGateway.http) to send requests to the API Gateway.

## Ocelot Cache Manager Performance

Ocelot Cache Manager is used, and it is installed via NuGet.

Performance comparison:

- **Without cache:** 126.01 ms
- **First request with cache:** 206.36 ms
- **Subsequent requests with cache (~1ms variance):** 9.58 ms

## Contribution

If you would like to contribute, please submit a pull request or open an issue.

---

# OcelotApiGatewayDemo (Türkçe)

Bu proje, Ocelot kullanarak bir API Gateway ve iki mikroservis (CarService ve UserService) içeren bir örnek uygulamadır. Proje, .NET 9.0 üzerinde geliştirilmiştir.

## Proje Yapısı

```
OcelotApiGatewayDemo/
│
├── ApiGateway/
│   ├── ApiGateway.csproj
│   ├── ApiGateway.http
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── ocelot.json
│   ├── Program.cs
│   └── Controllers/
│
├── CarService/
│   ├── CarService.csproj
│   ├── CarService.http
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Controllers/
│   ├── Mappings/
│   └── Models/
│
├── UserService/
│   ├── UserService.csproj
│   ├── appsettings.Development.json
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Controllers/
│   ├── Mappings/
│   └── Models/
│
└── OcelotApiGatewayDemo.sln
```

## Kurulum

### Gereksinimler

- .NET 9.0 SDK
- Visual Studio veya Visual Studio Code

### Adımlar

1. Bu repoyu klonlayın:

```sh
git clone https://github.com/kullanici/OcelotApiGatewayDemo.git
cd OcelotApiGatewayDemo
```

2. Gerekli NuGet paketlerini indirin:

```sh
dotnet restore
```

3. Projeyi derleyin:

```sh
dotnet build
```

## Çalıştırma

### ApiGateway Çalıştırma

```sh
cd ApiGateway
dotnet run
```

### CarService Çalıştırma

```sh
cd CarService
dotnet run
```

### UserService Çalıştırma

```sh
cd UserService
dotnet run
```

## Yapılandırma

### Ocelot Konfigürasyonu

Ocelot konfigürasyonu [`ApiGateway/ocelot.json`](ApiGateway/ocelot.json) dosyasında bulunur. Bu dosya, API Gateway'in yönlendirme kurallarını ve diğer ayarlarını içerir.

### Uygulama Ayarları

Her bir servis için uygulama ayarları `appsettings.json` ve `appsettings.Development.json` dosyalarında bulunur.

## Kullanım

### API İstekleri

API isteklerini test etmek için `*.http` dosyalarını kullanabilirsiniz. Örneğin, [`ApiGateway/ApiGateway.http`](ApiGateway/ApiGateway.http) dosyasını kullanarak API Gateway'e istek gönderebilirsiniz.

## Ocelot Cache Manager Performansı

Projede Ocelot Cache Manager kullanılmaktadır ve NuGet üzerinden yüklenmiştir.

Performans karşılaştırması:

- **Cache olmadan:** 126.01 ms
- **Cache'li ilk istek:** 206.36 ms
- **Cache'li ikinci ve sonraki her istek (~1ms farkla):** 9.58 ms

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.

