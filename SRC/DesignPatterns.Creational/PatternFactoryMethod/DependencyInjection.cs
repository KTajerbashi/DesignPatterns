using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns.Creational.PatternFactoryMethod;

public static class DependencyInjection
{
    public static IServiceCollection AddPatternFactoryMethod(this IServiceCollection services)
    {
        // Register message factories
        services.AddTransient<EmailMessageFactory>();
        services.AddTransient<SmsMessageFactory>();

        //services.AddTransient<IMessageFactory, EmailMessageFactory>();
        //services.AddTransient<IMessageFactory, SmsMessageFactory>();

        return services;
    }
}