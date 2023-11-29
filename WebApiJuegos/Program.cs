var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

// Interfaces DataAccess
builder.Services.AddScoped<DataAccess.Interfaces.ITipoJuegoDA, DataAccess.Clases.TipoJuegoDA>();

// Interfaces BusinessLogic
builder.Services.AddScoped<BusinessLogic.Interfaces.ITipoJuegoBL, BusinessLogic.Clases.TipoJuegoBL>();

// Se realiza la inicializacion de los objetos
Models.General.GlobalVariables.TipoJuegos = new List<Models.TipoJuego.TipoJuego>();
Models.General.GlobalVariables.TipoJuegosFiltrados = new List<Models.TipoJuego.TipoJuego>();

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
