using Day_6;
using Day_6.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// --- 1. Configure Services ---

// Add Controllers with Views support (MVC Pattern)
builder.Services.AddControllersWithViews();

// 1.1. Configure Database Connection (EF Core)
// Retrieve connection string from appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                       ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Register the DbContext for Dependency Injection
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// 1.2. Configure Repository for Dependency Injection (DI)
// This tells the app to use ProductRepository whenever IProductRepository is requested.
builder.Services.AddScoped<IProductRepository, ProductRepository>();


// --- 2. Build and Configure the HTTP Request Pipeline ---

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Enables serving static files (CSS, JS)

app.UseRouting();

app.UseAuthorization();

// Define the MVC routing structure
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=Index}/{id?}");

app.Run();