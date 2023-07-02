using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//servis kaydı
 
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));//veri tabanı bağlantı servisi
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default",
"{controller=Home}/{action=Index}/{id?}");

app.Run();
