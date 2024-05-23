using DesignPatterns.Extentions.Tools;

namespace DesignPatterns.Extentions.Exceptions.Documentation.BaseExceptionService
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
