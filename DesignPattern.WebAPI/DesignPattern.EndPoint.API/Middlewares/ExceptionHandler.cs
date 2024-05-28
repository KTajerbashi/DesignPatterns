using DataAccesses.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace DesignPattern.EndPoint.API.Middlewares;

// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
public class ExceptionHandler
{
    private readonly ILogger<ExceptionHandler> _logger;
    private readonly RequestDelegate _next;

    public ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            //_logger.Log(logLevel:LogLevel.Information, "===================================================================");
            //_logger.Log(logLevel:LogLevel.Trace, "::::::::::::::::    ExceptionHandler => Log Trace");
            //_logger.Log(logLevel:LogLevel.Debug, "::::::::::::::::    ExceptionHandler => Log Debug");
            //_logger.Log(logLevel:LogLevel.Information, "::::::::::::::::    ExceptionHandler => Log Information");
            //_logger.Log(logLevel:LogLevel.Warning, "::::::::::::::::    ExceptionHandler => Log Warning");
            //_logger.Log(logLevel:LogLevel.Error, "::::::::::::::::    ExceptionHandler => Log Error");
            //_logger.Log(logLevel:LogLevel.Critical, "::::::::::::::::    ExceptionHandler => Log Critical");
            //_logger.Log(logLevel:LogLevel.Information, "===================================================================");
            var model = new Person
            {
                ID = 1,
                Guid = Guid.NewGuid(),
                Name = "Kamran",
                Family = "Tajerbashi"
            };
            _logger.LogInformation("New Person {Person}", model);
            await _next(httpContext);
        }
        catch (Exception ex)
        {

            throw;
        }
    }
}
// Extension method used to add the middleware to the HTTP request pipeline.
public static class ExceptionHandlerExtensions
{
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ExceptionHandler>();
    }
}
