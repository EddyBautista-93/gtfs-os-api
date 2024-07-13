using System.Security.Cryptography.X509Certificates;
using gtfs_api.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Route = gtfs_api.Data.Route;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Dependency Injections
builder.Services.AddDbContext<GTFSDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"
    ))
);

var app = builder.Build();


// create a new service scope to ensure that scoped services are properly disposed of 
using(var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<GTFSDbContext>();

    dbContext.Database.Migrate();
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/", () => "Test Test test");

app.MapPost("/fileupload",async (IFormFile file, [FromServices] GTFSDbContext dbContext) =>
{
    if(file.Length == 0 || file == null)
        return Results.BadRequest("No file uploaded -- please upload valid file");

    // checks for file type.
    if(file.ContentType != "text/plain")    
        return Results.BadRequest("Invalid file type -- please upload valid file");     

    // parse the file and read the data
    List<Route> routes = new List<Route>();
    using(var streamReader = new StreamReader(file.OpenReadStream()))
    {
        string line;
        bool isFirstLine = true;
        while((line = await streamReader.ReadLineAsync()) != null)
        {
            if(isFirstLine)
            {
                // Skip the header line 
                isFirstLine = false; 
                continue;
            }

            var values = line.Split(',');

            var route = new Route
            {
                route_id = int.Parse(values[0]),
                agency_id = values[1],
                route_short_name = values[2],
                route_long_name = values[3],
                route_desc = values[4],
                route_type = values[5],
                route_url = values[6],
                route_color = values[7],
                route_text_color = values[8]
            };
            routes.Add(route);
        }
    }
    // save the data 
    dbContext.Routes.AddRange(routes);
    await dbContext.SaveChangesAsync();
    return Results.Ok("File Uploaded Successfully");  
}).DisableAntiforgery(); // only for testing

app.MapGet("/routes", async ([FromServices] GTFSDbContext dbContext) =>
{
    var routes = await dbContext.Routes.ToListAsync();
    return Results.Ok(routes);
});

app.Run();

// functions for file upload 