using Steeltoe.Extensions.Logging;
using Steeltoe.Management.Endpoint;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add Steeltoe Management Endpoints
builder.Services.AddAllActuators();

// Add Steeltoe Dynamic Logging
builder.Logging.AddDynamicConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAllActuators(conventionBuilder => { });

app.Run();