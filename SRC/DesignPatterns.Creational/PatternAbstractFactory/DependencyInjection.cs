using DesignPatterns.Creational.PatternAbstractFactory.Dark;
using DesignPatterns.Creational.PatternAbstractFactory.Light;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.PatternAbstractFactory;

public static class DependencyInjection
{
    public static IServiceCollection AddPatternAbstractFactory(this IServiceCollection services)
    {
        services.AddTransient<LightUIFactory>();
        services.AddTransient<DarkUIFactory>();
        return services;
    }
}
