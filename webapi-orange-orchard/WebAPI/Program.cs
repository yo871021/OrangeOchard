using Dao.Interface;
using Model.ViewModel.CommonSettings;
using Service.Implement;
using Service.Interface;
using Tool.DataBase.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.Configure<CommonSettings>(builder.Configuration.GetSection("CommonSettings"));
builder.Services
    .Scan(scan => scan
    .FromAssemblyOf<IService>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());
builder.Services
    .Scan(scan => scan
    .FromAssemblyOf<IRepository>()
    .AddClasses()
    .AsImplementedInterfaces()
    .WithScopedLifetime());
builder.Services.AddTransient<DBServiceBase>();

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
