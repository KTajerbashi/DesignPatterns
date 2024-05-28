using DesignPatterns.Extensions;

namespace DesignPattern.EndPoint.API.Exceptions.BaseExceptionService
{
    public abstract class BaseExceptionServices
    {
        protected readonly DesignConsole DesignConsole;
        public BaseExceptionServices()
        {
            DesignConsole = DesignConsole.DesignInstance();
        }
    }
}
