using Microsoft.EntityFrameworkCore;
using InvoiceApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Razor Pages servisini ekleyelim
builder.Services.AddRazorPages();

// Veri tabaný servisini ekleyelim
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionString);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();

app.Run();