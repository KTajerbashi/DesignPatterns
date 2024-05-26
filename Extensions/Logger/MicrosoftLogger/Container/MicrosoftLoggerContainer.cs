
using NLog;

namespace DesignPatterns.Extensions.Logger.MicrosoftLogger.Container
{
    public class MicrosoftLoggerContainer
    {
        private readonly ILogger _logger;
        public MicrosoftLoggerContainer(ILogger logger)
        {
            _logger = logger;
        }

        public void Execute()
        {
            Console.WriteLine("MicrosoftLoggerContainer.Execute()");
            _logger.Log(LogLevel.Trace, "=======> Log Level Trace");
            _logger.Log(LogLevel.Debug, "=======> Log Level Debug");
            //_logger.Log(LogLevel.Info, LogEventId.InsertItem, "=======> Log Level Information");
            _logger.Log(LogLevel.Warn, "=======> Log Level Warning");
            _logger.Log(LogLevel.Error, "=======> Log Level Error");
            //_logger.Log(LogLevel.Critical, "=======> Log Level Critical");
            //_logger.Log(LogLevel.None, "=======> Log Level None");
        }
    }
}
