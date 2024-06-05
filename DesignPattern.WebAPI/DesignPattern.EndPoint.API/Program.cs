using DataAccesses.Contexts.CommandsContextDatabase;
using DataAccesses.Contexts.QueriesContextDatabase;
using DesignPattern.EndPoint.API.DIContainer;
using DesignPattern.EndPoint.API.Middlewares;
using Microsoft.EntityFrameworkCore;
using NLog.Extensions.Logging;
using NLog.Web;
var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();

try
{

    var builder = WebApplication.CreateBuilder(args);
    var Configuration = builder.Configuration;
    builder.Services.AddDbContext<CommandsDatabaseContext>(options =>
    {
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionCommand"));
    });
    builder.Services.AddDbContext<QueriesDatabaseContext>(options =>
    {
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionQuery"));
    });
    builder.Services.AddPatterServices();

    //configure logging
    builder.Services.AddLogging(loggingBuilder =>
    {
        loggingBuilder.ClearProviders();
        loggingBuilder.AddNLog().SetMinimumLevel(LogLevel.Trace);
    });
    // Add services to the container.
    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    var app = builder.Build();
    // Configure the HTTP request pipeline.
    app.UseMyMiddleware();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    logger.Error(ex, "Stopped program because of exception");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}