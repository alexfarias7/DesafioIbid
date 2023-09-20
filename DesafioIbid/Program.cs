using DesafioIbid.Datas;
using DesafioIbid.Repositories;
using DesafioIbid.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SystemProductDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
   );

//builder.Services
 //   .AddDbContext<SystemProductDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddScoped<IProduct, ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
