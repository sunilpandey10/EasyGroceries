using EasyGroceries.API.Repositories;
using EasyGroceries.API.Services;
using EasyGroceries.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IGroceryRepository, GroceryRepository>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IOrderProcessor, OrderProcessor>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ecommapp", builder =>
    {
        builder.WithOrigins("http://localhost:4200") // Angular default port
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseCors("ecommapp");


app.UseAuthorization();

app.MapControllers();

app.Run();


