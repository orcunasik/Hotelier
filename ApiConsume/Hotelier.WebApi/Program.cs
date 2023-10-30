using Hotelier.Service.Extensions;
using Hotelier.Repository.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.LoadMyRepositories();
builder.Services.LoadMyServices();
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("HotelierApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("HotelierApiCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
