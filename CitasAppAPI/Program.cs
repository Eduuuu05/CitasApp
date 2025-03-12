using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

// Obtener la cadena de conexión desde appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new Exception("La cadena de conexión 'DefaultConnection' no está configurada en appsettings.json");

// Configurar DbContext para MySQL con Pomelo
builder.Services.AddDbContext<CitasAppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddControllers();

// Configuración de Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CitasApp API",
        Version = "v1",
        Description = "API para la gestión de citas",
        Contact = new OpenApiContact
        {
            Name = "Tu Nombre",
            Email = "tu@email.com"
        }
    });
});

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configurar middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Orden correcto del middleware
app.UseCors("AllowAllOrigins"); // CORS antes de autorización
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
