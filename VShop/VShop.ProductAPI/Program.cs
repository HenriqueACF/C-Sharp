using Microsoft.EntityFrameworkCore;
using VShop.ProductAPI.Properties.Context;

var builder = WebApplication.CreateBuilder(args);

var mySQLConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDBContext>(options =>
    options.UseMySql(mySQLConnection, ServerVersion.AutoDetect(mySQLConnection)));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();