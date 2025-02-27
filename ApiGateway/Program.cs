using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Cache.CacheManager;

var builder = WebApplication.CreateBuilder(args);

// Ocelot yapılandırmasını ekle
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

// HttpClient desteği
builder.Services.AddHttpClient();

// Ocelot servisini ekle
builder.Services.AddOcelot().AddCacheManager(x =>
{
    // CacheManager yapılandırmasını burada yapıyoruz
    x.WithDictionaryHandle(); // MemoryCache kullanmak için
});;

var app = builder.Build();

// Ocelot middleware'i ekle
await app.UseOcelot();

app.Run();
