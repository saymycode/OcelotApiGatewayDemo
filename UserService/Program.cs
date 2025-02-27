using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using UserService.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Controller ve AutoMapper kayıtları
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();
