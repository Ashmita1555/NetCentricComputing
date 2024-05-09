using CURD.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using MySql.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CURD.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<CURDContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CURDContext") ?? throw new InvalidOperationException("Connection string 'CURDContext' not found.")));
builder.Services.AddDbContext<DataDbContext>(option =>
{
	option.UseMySQL(builder.Configuration.GetConnectionString("DevConnection"));
});

// Add services to the container.
builder.Services.AddControllersWithViews();

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
