using CloudSQL.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Added configuration for PostgreSQL
var configuration = builder.Configuration;
builder.Services.AddDbContext<UserContext>(options =>
    options.UseNpgsql(configuration.GetValue("DbConnStr", ""))
    );

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();