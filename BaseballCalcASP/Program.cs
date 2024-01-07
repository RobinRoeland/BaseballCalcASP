using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BaseballCalcASP.Data;
using Microsoft.AspNetCore.Identity;
using BaseballCalcASP.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BaseballCalcASPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseballCalcASPContext") ?? throw new InvalidOperationException("Connection string 'BaseballCalcASPContext' not found.")));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BaseballCalcASPContext>()
    .AddDefaultTokenProviders();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
