using ExcelOperation.BackgroundServices;
using ExcelOperation.Interfaces;
using ExcelOperation.Model;
using ExcelOperation.Repositories;
using ExcelOperation.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<StudentDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-G67R1RV\\SQLEXPRESS;Database=ExcelDb;Trusted_connection=true;TrustServerCertificate=true");
});
//builder.Services.AddSingleton<StudentRepo>();
builder.Services.AddScoped<IStudent, StudentRepo>();
builder.Services.AddSingleton<ExcelDataImportServices>();

//builder.Services.AddHostedService<SimpleService1>();
//builder.Services.AddHostedService<SimpleService2>();

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
