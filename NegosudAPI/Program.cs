using Microsoft.EntityFrameworkCore;
using Negosud.Context;
using NuGet.Protocol.Core.Types;

var builder = WebApplication.CreateBuilder(args);

//chaine de connexion
string connexionString = builder.Configuration.GetConnectionString("MainConnectionString") ??
    throw (new Exception("Connection string is missing"));

builder.Services.AddDbContext<NegosudContext>(options => options
        .UseMySql(connexionString, ServerVersion.AutoDetect(connexionString)));

builder.Services.AddScoped<NegosudContext>();


// Add services to the container.

builder.Services.AddControllers();
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

app.Run();
