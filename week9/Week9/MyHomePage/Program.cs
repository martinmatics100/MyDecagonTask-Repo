using Microsoft.EntityFrameworkCore;
using MyHomePage.Data;
using MyHomePage.Models;
using MyHomePage.Repositories.Hotel_Repository;
using MyHomePage.Repositories.User_Repository;

using static System.Collections.Specialized.BitVector32;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add session service
var connectionString = "DefaultConnection";

//dbcontext Registration
builder.Services.AddDbContext<HotelDataBaseContext>(options => { options.UseSqlServer(connectionString); });

builder.Services.AddScoped<IHotelRepository>(provider => { var dbcontext = provider.GetRequiredService<HotelDataBaseContext>(); return new HotelRepository(dbcontext); });
builder.Services.AddScoped<IUserRepository>(provider => { var dbcontext = provider.GetRequiredService<HotelDataBaseContext>(); return new UserRepository(dbcontext); });

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
//app.UseSession();


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();