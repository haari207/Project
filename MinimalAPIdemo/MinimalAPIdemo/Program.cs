
using MinimalAPIdemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

var dc = new b248dbContext();
app.MapPost("Addstudent", (Studentstbl s) =>
{
    dc.Studentstbls.Add(s);
    return dc.SaveChanges();
});

app.MapDelete("delete", (int id) =>
{
    var res = dc.Studentstbls.Find(id);
    dc.Studentstbls.Remove(res);
    return dc.SaveChanges();
});

app.MapGet("/showstudent/{id}",(int id) => dc.Studentstbls.Where(c=>c.Stid == id));

app.MapGet("show/{id}", (int id) =>
{
    var res = (from t in dc.Studentstbls where t.Stid == id select t).FirstOrDefault();
    if (res != null)
    {
         return Results.Ok(res);
    }
    else
    {
       return  Results.NotFound();
    }
});

app.MapPost("/validate", (string name) => $"Hello, {name}!")
   .AddEndpointFilter(async (context, next) =>
   {
       var name = context.GetArgument<string>(0);
       if (string.IsNullOrEmpty(name))
           return Results.BadRequest("Name is required.");

       return await next(context);
   });

app.MapGet("report", () =>
{
    return "report method called";
}).AddEndpointFilter<MyLoggerMiddleware>();

public class MyLoggerMiddleware : IEndpointFilter
{
    // run some logic before calling the method
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        Console.WriteLine($"Request: {context.HttpContext.Request.Method} {context.HttpContext.Request.Path}");
        Console.WriteLine("===========");
        // Call the next endpoint or filter
        var result = await next(context);
        Console.WriteLine("===========");
        // Post-processing: Log the response result
        Console.WriteLine($"Response: {result}");

        return result;
    }
}


app.UseHttpsRedirection();

//string[] mystudents = { "hari", "kavya", "priya", "Ram","sai" };

//hoe tp create get method
//app.MapGet("/showall", () => mystudents.ToList());
//app.MapGet("/s", (string s) => mystudents.Where(c => c.Contains(s)));

app.Run();

 
