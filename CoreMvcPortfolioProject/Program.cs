using CoreMvcPortfolioProject.DAL.Context;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index"; // Giriþ yapmayan kullanýcýlar buraya yönlendirilecek
        options.LogoutPath = "/Login/LogOut";
    });

builder.Services.AddSession();

builder.Services.AddFluentValidationAutoValidation(). // Model State ve FluentValidation entegre olmasý
                 AddFluentValidationClientsideAdapters().  // Tarayýcý tarafýnda hata göstermek için
                 AddValidatorsFromAssembly(Assembly.GetExecutingAssembly()); // Validator sýnýflarýný tanýmasý için ( :Abstract<Category> )


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PortfolioContext>();

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

app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PortfolioLayout}/{action=Index}/{id?}");

app.Run();
