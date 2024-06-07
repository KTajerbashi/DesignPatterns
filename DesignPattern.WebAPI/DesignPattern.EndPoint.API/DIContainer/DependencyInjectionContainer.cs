using DesignPatterns.BehavioralPatterns.Interpreter.Container;
using DesignPatterns.BehavioralPatterns.Iterator.Container;
using DesignPatterns.BehavioralPatterns.Mediator.Container;
using DesignPatterns.BehavioralPatterns.Memento.Container;
using DesignPatterns.BehavioralPatterns.Observer.Container;
using DesignPatterns.BehavioralPatterns.State.Container;
using DesignPatterns.BehavioralPatterns.Visitor.Container;

namespace DesignPattern.EndPoint.API.DIContainer
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection AddPatterServices(this IServiceCollection services)
        {
            services.AddScoped<MementoContainer>();
            services.AddScoped<ObserverContainer>();
            services.AddScoped<VisitorContainer>();
            services.AddScoped<MediatorContainer>();
            services.AddScoped<IteratorContainer>();
            services.AddScoped<StateContainer>();
            services.AddScoped<InterpreterContainer>();
            return services;
        }
    }
}
