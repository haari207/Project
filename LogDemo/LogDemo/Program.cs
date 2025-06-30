using Serilog;
using Microsoft.Extensions.Logging.EventLog;
using Serilog.Formatting.Json;
using Microsoft.AspNetCore.HttpLogging;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Log.Logger=new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console(new JsonFormatter())
//    .WriteTo.File(new JsonFormatter(),"Logs/log.json",rollingInterval:RollingInterval.Day)
//    .CreateLogger();
//builder.Host.UseSerilog();

builder.Logging.AddConsole();

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.ResponseStatusCode;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseHttpLogging();

app.UseStaticFiles();
app.UseRouting();                                            

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
