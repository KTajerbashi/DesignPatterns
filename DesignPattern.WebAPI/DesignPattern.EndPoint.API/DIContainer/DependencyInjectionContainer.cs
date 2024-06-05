using DesignPatterns.BehavioralPatterns.Memento.Container;
using DesignPatterns.BehavioralPatterns.Observer.Container;

namespace DesignPattern.EndPoint.API.DIContainer
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection AddPatterServices(this IServiceCollection services)
        {
            services.AddScoped<MementoContainer>();
            services.AddScoped<ObserverContainer>();
            return services;
        }
    }
}
