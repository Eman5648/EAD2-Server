using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CA2BookServer.Data;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CA2BookServerContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CA2BookServerContext") ?? throw new InvalidOperationException("Connection string 'CA2BookServerContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
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
