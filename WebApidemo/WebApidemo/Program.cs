using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();

//builder.Services.AddControllers(c =>
//{
//    c.OutputFormatters.Add(new XmlSerializerOutputFormatter());
//    c.OutputFormatters.RemoveType(typeof(SystemTextJsonOutputFormatter));
//    c.ReturnHttpNotAcceptable = true; // if we dont want to get default one if im trying to access another format it should say not acceptable
//});



//builder.Services.AddApiVersioning(o =>
//{
//    o.AssumeDefaultVersionWhenUnspecified = true; //call default version if not specified
//    o.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);  //default version
//    o.ReportApiVersions = true;
//    o.ApiVersionReader = ApiVersionReader.Combine(
//        new QueryStringApiVersionReader("v"),
//        new HeaderApiVersionReader("X-version"),
//        new MediaTypeApiVersionReader("ver"));
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
