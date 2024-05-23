using DesignPatterns.Extensions.Tools;

namespace DesignPatterns.Extensions.Exceptions.Documentation.BaseExceptionService
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
