var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// Interfaces DataAccess
builder.Services.AddScoped<DataAccess.Interfaces.ITipoJuegoDA, DataAccess.Clases.TipoJuegoDA>();
builder.Services.AddScoped<DataAccess.Interfaces.IJuegoDA, DataAccess.Clases.JuegoDA>();

// Interfaces BusinessLogic
builder.Services.AddScoped<BusinessLogic.Interfaces.ITipoJuegoBL, BusinessLogic.Clases.TipoJuegoBL>();
builder.Services.AddScoped<BusinessLogic.Interfaces.IJuegoBL, BusinessLogic.Clases.JuegoBL>();

// Se realiza la inicializacion de los objetos
Models.General.GlobalVariables.TipoJuegos = new List<Models.TipoJuego.TipoJuego>();
Models.General.GlobalVariables.TipoJuegosFiltrados = new List<Models.TipoJuego.TipoJuego>();

Models.General.GlobalVariables.Juegos = new List<Models.Juego.Juego>();
Models.General.GlobalVariables.JuegosFiltrados = new List<Models.Juego.Juego>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
    options.DocumentTitle = "Web Api Juegos";
});

app.Run();
