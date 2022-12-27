using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UdemyJwtApp.Back.Core.Application.Interfaces;
using UdemyJwtApp.Back.Core.Application.Mappings;
using UdemyJwtApp.Back.Persistance.Context;
using UdemyJwtApp.Back.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly()); 

builder.Services.AddDbContext<UdemyJwtContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local"));
});

builder.Services.AddAutoMapper(opt =>
{
    opt.AddProfiles(new List<Profile>
    {
       new ProductProfile(),
       new CategoryProfile()
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
