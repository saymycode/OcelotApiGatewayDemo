using CarService.Mappings;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingProfile)); // AutoMapper Ekle

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    _ = endpoints.MapControllers();
});

app.Run();
