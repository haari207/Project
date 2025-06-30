using CodeFirstApp;
using CodeFirstApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddTransient<Imyinter,MyMathServices>();

builder.Services.AddDbContext<SongContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("mycon")));
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
//app.UseMiddleware<Custommiddleware>();
//app.Use(async (context, next) => {  await context.Response.WriteAsync("first executed before request");
//    await next();
//    await context.Response.WriteAsync("first executed after response");
//    });
app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();// check authentication then send the page to the server 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
