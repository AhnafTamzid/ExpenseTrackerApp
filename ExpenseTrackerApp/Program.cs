using ExpenseTrackerApp.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using ExpenseTrackerApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
string cs = "server=.;database=ExpenseTrackerApp;trusted_connection=true";
builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(cs));
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

#if DEBUG
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
#endif

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
    pattern: "{controller=Expense}/{action=Index}/{id?}");

app.Run();
