using DesignPattern.EndPoint.API.AppHost;

StartApplication.RunApplication(() =>
{
    var builder = WebApplication.CreateBuilder(args);
    builder
    .ConfigureServices()
    .ConfigurePipeline()
    .Run();
});




