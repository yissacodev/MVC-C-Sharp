using Microsoft.EntityFrameworkCore;
using MVC_project.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Configuracion conexión postgres
builder.Services.AddEntityFrameworkNpgsql().AddDbContext<Context>(options => 
    options.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=users_db;User Id=postgres;Password=1234;"));


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
