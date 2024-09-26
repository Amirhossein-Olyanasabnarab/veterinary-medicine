using ApplicationServices.Owners;
using ApplicationServices.Vets;
using Contracts;
using Data.Sql;
using Data.Sql.Context;
using Data.Sql.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IVetService, VetService>();
builder.Services.AddScoped<IOwnerService, OwnerService>();
builder.Services.AddScoped<IVetRepository, VetSqlRepository>();
builder.Services.AddScoped<IOwnerRepository, OwnerSqlRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddDbContext<ApplicationContext>
    (option => option.UseSqlServer
        (builder.Configuration.GetConnectionString("DefaultConnection"))
     );

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
