using FluentMigrator.Runner;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddFluentMigratorCore()
    .ConfigureRunner(config => 
        config.AddSqlServer()
        .WithGlobalConnectionString("Server=localhost;Database=master;Trusted_Connection=True;")
        .ScanIn(Assembly.GetExecutingAssembly()).For.All())
    .AddLogging(config => config.AddFluentMigratorConsole());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

using var scope = app.Services.CreateScope();
var migrator = scope.ServiceProvider.GetService<IMigrationRunner>();
migrator.ListMigrations();

app.Run();
