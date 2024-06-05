using DesignPatterns.Memento.Container;

namespace DesignPattern.EndPoint.API.DIContainer
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection AddPatterServices(this IServiceCollection services)
        {
            services.AddScoped<MementoContainer>();
            return services;
        }
    }
}
