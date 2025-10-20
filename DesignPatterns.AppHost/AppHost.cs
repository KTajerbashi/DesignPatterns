var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DesignPatterns_Presentation>("designpatterns-presentation");

builder.Build().Run();
