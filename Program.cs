using CameraReview.Models;
using CameraReview.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<ProductDataBaseSettings>
    (builder.Configuration.GetSection("DevNetProductsStorageDatabase"));

builder.Services.AddSingleton<ProductsServices>(); //singleton

builder.Services.Configure<ProductDataBaseSettings>
    (builder.Configuration.GetSection("DevNetCamerasStorageDatabase"));

builder.Services.AddSingleton<CameraServices>(); //singleton


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
