
# OcelotApiGatewayDemo

Bu proje, Ocelot kullanarak bir API Gateway ve iki mikroservis (CarService ve UserService) içeren bir örnek uygulamadır. Proje, .NET 9.0 üzerinde geliştirilmiştir.

## Proje Yapısı

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
└── [`OcelotApiGatewayDemo.sln`](OcelotApiGatewayDemo.sln )

## Kurulum

### Gereksinimler

- .NET 9.0 SDK
- Visual Studio veya Visual Studio Code

### Adımlar

1. Bu repoyu klonlayın:
    sh
    git clone https://github.com/kullanici/OcelotApiGatewayDemo.git
    cd OcelotApiGatewayDemo
    

2. Gerekli NuGet paketlerini indirin:
    sh
    dotnet restore
    

3. Proj derleyin:
    sh
    dotnet build
    

## Çalıştırma

### ApiGateway

ApiGateway'i çalıştırmak için aşağıdaki komutu kullanın:
sh
cd ApiGateway
dotnet run


### CarService

CarService'i çalıştırmak için aşağıdaki komutu kullanın:
sh
cd CarService
dotnet run


### UserService

UserService'i çalıştırmak için aşağıdaki komutu kullanın:
sh
cd UserService
dotnet run


## Yapılandırma

### Ocelot Konfigürasyonu

Ocelot konfigürasyonu [`ApiGateway/ocelot.json`](ApiGateway/ocelot.json ) dosyasında bulunur. Bu dosya, API Gateway'in yönlendirme kurallarını ve diğer ayarları içerir.

### Uygulama Ayarları

Her bir servis için uygulama ayarları `appsettings.json` ve `appsettings.Development.json` dosyalarında bulunur.

## Kullanım

### API İstekleri

API isteklerini test etmek için `*.http` dosyalarını kullanabilirsiniz. Örneğin, [`ApiGateway/ApiGateway.http`](ApiGateway/ApiGateway.http ) dosyasını kullanarak API Gateway'e istek gönderebilirsiniz.

## Katkıda Bulunma

Katkıda bulunmak isterseniz, lütfen bir pull request gönderin veya bir issue açın.
