using gtfs_api.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<GTFSDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"
    ))
);

var app = builder.Build();


// create a bew service scope to ensure that scoped services are properly disposed of 
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

app.MapPost("/fileupload",(IFormFile file) =>
{
    if(file.Length == 0 || file == null)
        return Results.BadRequest("No file uploaded -- please upload valid file");

    // checks for file type.
    if(file.ContentType != "text/plain")    
        return Results.BadRequest("Invalid file type -- please upload valid file");       

});

app.Run();

// functions for file upload 