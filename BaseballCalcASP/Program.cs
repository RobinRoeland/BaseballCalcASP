using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BaseballCalcASP.Data;
using Microsoft.AspNetCore.Identity;
using BaseballCalcASP.Models;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BaseballCalcASPContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BaseballCalcASPContext") ?? throw new InvalidOperationException("Connection string 'BaseballCalcASPContext' not found.")));

builder.Services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BaseballCalcASPContext>()
    .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

// Localizatie toevoegen
builder.Services.AddLocalization(options => options.ResourcesPath = "Localizing");

builder.Services.AddMvc()
    .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
    .AddDataAnnotationsLocalization();

// Configure supported cultures
var supportedCultures = new[]
{
        new CultureInfo("en-US"),
        new CultureInfo("nl-BE"),
        new CultureInfo("fr-FR")
        // Add more cultures as needed
    };

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

var app = builder.Build();

// Als er nog geen database is maar wel een bestaande migration, dan wordt de database hier automatisch aangemaakt
using (var serviceScope = app.Services.CreateScope())
{
    var context = serviceScope.ServiceProvider.GetRequiredService<BaseballCalcASPContext>();
    context.Database.Migrate();
}


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// zonder deze lijn werkt de localizatie niet
app.UseRequestLocalization();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
