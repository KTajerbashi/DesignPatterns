using DataAccesses.Contexts.CommandsContextDatabase;
using DataAccesses.Contexts.QueriesContextDatabase;
using DesignPattern.EndPoint.API.DIContainer;
using DesignPattern.EndPoint.API.Middlewares;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using NLog.Web;

namespace DesignPattern.EndPoint.API.AppHost;

public static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        var Configuration = builder.Configuration;

        builder.Services.AddDbContext<CommandsDatabaseContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });
        builder.Services.AddDbContext<QueriesDatabaseContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });
        builder.Services.AddPatterServices();

        //configure logging
        builder.Services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.ClearProviders();
            loggingBuilder.AddNLog().SetMinimumLevel(LogLevel.Trace);
            //loggingBuilder.AddConsole().SetMinimumLevel(LogLevel.Trace);
        });

        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        return builder.Build();
    }
    public static WebApplication ConfigurePipeline(this WebApplication app)
    {
        app.UseMyMiddleware();
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        return app;
    }
}