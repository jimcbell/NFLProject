using Microsoft.AspNetCore.OData;
using NFL.OData.Service.Models;
using NFL.SqlServer.DataContext;

var builder = WebApplication.CreateBuilder(args);


// Configuration
IConfiguration config = builder.Configuration;
string? connectionString = config.GetConnectionString("NFL");   
if (string.IsNullOrEmpty(connectionString))
{
    throw new Exception("Connection string is null or empty.");
}


// Add services to the container.


builder.Services.AddNFLContext(connectionString);
builder.Services.AddControllers()
    .AddOData(
    options => options 
        .AddRouteComponents("nflplays",
        model: EDMModels.GetEdmModelForNFLPlay())
        // query options
        .Select() // enables the $select query option
        .Filter() // enables the $filter query option
        .Expand() // enables the $expand query option - no related tables yet
        .OrderBy() // enables the $orderby query option
        .SetMaxTop(100) // limits the number of results returned to 100
        .Count() // enables the $count query option
    );
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

app.MapControllers();

app.Run();

