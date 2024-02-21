using Microsoft.EntityFrameworkCore;
using Negosud.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



//chaine de connexion
string connexionString = builder.Configuration.GetConnectionString("MainConnectionString") ??
    throw (new Exception("Connection string is missing"));

builder.Services.AddDbContext<NegosudContext>(options => options
        .UseMySql(connexionString, ServerVersion.AutoDetect(connexionString)));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
