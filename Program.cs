using CameraReview.Models;
using CameraReview.Services;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();

// Add services to the container products
builder.Services.Configure<ProductDataBaseSettings>
   (builder.Configuration.GetSection("DevNetProductsStorageDatabase"));
builder.Services.AddScoped<ProductsServices>(); // stateless

//Add services to the container cameras
builder.Services.Configure<CameraDataBaseSettings>
  (builder.Configuration.GetSection("DevNetCamerasStorageDatabase"));
builder.Services.AddScoped<CameraServices>(); //stateless


//Add services to the container Lens
builder.Services.Configure<LensDataBaseSettings>
    (builder.Configuration.GetSection("DevNetLensStorageDatabase"));
builder.Services.AddScoped<LensServices>(); //stateless

//Add services to the container Author
builder.Services.Configure<AuthorDataBaseSettings>
    (builder.Configuration.GetSection("DevNetAuthorStorageDatabase"));
builder.Services.AddScoped<AuthorServices>(); //stateless


//Add services to the container review
builder.Services.Configure<ReviewDataBaseSettings>
    (builder.Configuration.GetSection("DevNetReviewStorageDatabase"));
builder.Services.AddScoped<ReviewServices>(); //stateless/
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

//middlewares
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.UseResponseCaching();
app.MapRazorPages();
app.MapControllers();
app.Run();