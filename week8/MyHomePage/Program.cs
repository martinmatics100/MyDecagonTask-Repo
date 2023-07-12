using MyHomePage.Repositories.Hotel_Repository;
using MyHomePage.Repositories.User_Repository;

using static System.Collections.Specialized.BitVector32;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add session service
builder.Services.AddSession(options =>
{
    // Configure session options as needed
    options.Cookie.Name = "YourSessionCookieName";
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.IsEssential = true;
});
//Data Source = MARTINMATICS; Integrated Security = True; Persist Security Info=False; Pooling = False; Multiple Active Result Sets=False; Connect Timeout = 60; Encrypt = False; Trust Server Certificate=False; Command Timeout = 0
var connectionString = "Server=MARTINMATICS;Database=HotelDataBase;Trusted_Connection=True";
builder.Services.AddScoped<IUserRepository, UserRepository>(provider => new UserRepository(connectionString));

builder.Services.AddScoped<IHotelRepository, HotelRepository>(provider => new HotelRepository(connectionString));

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
app.UseSession();


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//| mostpicked1.png |                  |              |       | section1 |                      |
//| mostpicked2.png |                  |              |       | section1 |                      |
//| mostpicked3.png |                  |              |       | section1 |                      |
