using ElectronNET.API;
using oistigmes_desktop_app;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.WebHost.UseElectron(args);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

if (HybridSupport.IsElectronActive)
{
    ElectronApp.ElectronBootstrap();
}

app.Run();
