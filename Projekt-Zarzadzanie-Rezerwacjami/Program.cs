using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Projekt_Zarzadzanie_Rezerwacjami.Data;
using Projekt_Zarzadzanie_Rezerwacjami.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Projekt_Zarzadzanie_RezerwacjamiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Projekt_Zarzadzanie_RezerwacjamiContext") ?? throw new InvalidOperationException("Connection string 'Projekt_Zarzadzanie_RezerwacjamiContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
