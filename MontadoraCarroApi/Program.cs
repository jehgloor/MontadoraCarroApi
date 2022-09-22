using Microsoft.EntityFrameworkCore;
using MontadoraCarroApi.Controllers;
using MontadoraCarroApi.data;
using MontadoraCarroApi.model;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DbApllication>
    (options => options.UseMySql(
        "server=localhost;initial catalog=MontadoraCarroApi;uid=root;pwd=",
        Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql")));

var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();


}
app.Run();
