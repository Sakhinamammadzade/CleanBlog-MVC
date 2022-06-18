using CleanBlog.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<DataSeeding>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<BlogDbContext>(option =>
{
    option.UseSqlServer(connectionString);
});
var app = builder.Build();

app.UseStaticFiles();//wwwroot isletmek ucun
app.MapControllerRoute
 (
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
 );

app.Run();
