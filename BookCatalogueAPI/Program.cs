using BookCatalogueAPI.Models;
using Microsoft.EntityFrameworkCore;

/////////////////////////////////////
using MySql.Data.MySqlClient;

string cs = @"server=172.27.183.23;userid=root;password=password;database=test";

using var con = new MySqlConnection(cs);
con.Open();

MySqlCommand cmd = con.CreateCommand();
cmd.CommandText = "INSERT INTO books (id, title) VALUES (2, 'test2');"; // This works.
MySqlDataReader reader = cmd.ExecuteReader();

Console.WriteLine($"MySQL version : {con.ServerVersion}");
con.Close();

/////////////////////////////

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CatalogueContext>(options =>
{
    options.UseInMemoryDatabase("BookCatalogue");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
