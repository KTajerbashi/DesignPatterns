using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.SharedKernel;

public static class DependencyInjection
{
    public static IServiceCollection AddServiceContainers(this IServiceCollection service)
    {
        return service;
    }
}