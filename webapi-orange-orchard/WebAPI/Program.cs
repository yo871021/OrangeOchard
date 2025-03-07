using Common.Model;
using DataBase.Model;
using DataBase.Repository;
using Repository.Interface;
using Serilog;
using Service.Implement;
using Service.Interface;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Debug(outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
            .WriteTo.Map(
            keySelector: e => DateTime.Now.ToString("yyyy-MM-dd"),
            configure: (date, wt) => wt.File(
                path: $"LOG/{date}/Application/Application_Runtime_Log_.txt",
                rollingInterval: RollingInterval.Hour, 
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
            )
            .CreateLogger();

        try
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Host.UseSerilog();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AngularFrontend",
                    policy => policy
                    .WithOrigins(builder.Configuration["CommonSettings:ApiUrl:AngularFrontend"] ?? string.Empty)
                    .AllowAnyHeader()
                    .AllowAnyMethod());
            });

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

            DBServiceBase.ConfigureDBOptions(
                builder.Configuration.GetSection("CommonSettings:Database")
                .Get<Dictionary<string, DBOptions>>() ?? []);

            builder.Services
                .AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                }); ;
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
            app.UseCors("AngularFrontend");
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Application start-up failed");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}