using Hospital.Library.DAL;
using Hospital.Library.Entities;
using Hospital.Library.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors
    (opt =>
    {
        opt.AddDefaultPolicy(builder =>
        {
            builder.WithOrigins("http://localhost:4200")
            .SetIsOriginAllowedToAllowWildcardSubdomains()
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
        });
    });
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
builder.Services.AddScoped<IDepartment, DepartmentDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.DocumentTitle = "Hospital App APIs";
        c.DefaultModelsExpandDepth(-1);
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x =>
{
    x.AllowAnyOrigin();
    x.AllowAnyMethod();
    x.AllowAnyHeader();
});
app.Run();
