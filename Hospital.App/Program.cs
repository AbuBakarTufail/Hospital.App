using Hospital.Library.DAL;
using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string? dbConnection = builder.Configuration.GetConnectionString("DbConnect");
builder.Services.AddDbContext<HmsContext>(opt =>
{
    opt.UseSqlServer(dbConnection);
    opt.UseSqlServer(dbConnection, b => b.MigrationsAssembly("Hospital.App"));
});
builder.Services.AddScoped<ICity, CityDal>();
builder.Services.AddScoped<ICountry, CountryDal>();

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
