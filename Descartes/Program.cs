using Descartes;
using Descartes.Persistence;

var builder = WebApplication.CreateBuilder(args);

var config = builder.Configuration;
string connectionString = config.GetConnectionString("Localhost");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDescartesContext(connectionString);
builder.Services.AddDescartesDependencyInjection();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
