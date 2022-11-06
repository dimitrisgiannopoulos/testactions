using BookCatalogueAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<BookCatalogueContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

SeedDatabase.Seed();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

// More information on adding data protection can be found here: https://learn.microsoft.com/en-us/aspnet/core/security/data-protection/configuration/overview?view=aspnetcore-6.0
// builder.Services.AddDataProtection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// Deletes the database 
using (var db = new BookCatalogueContext())
{
    db.Database.EnsureDeleted();
}