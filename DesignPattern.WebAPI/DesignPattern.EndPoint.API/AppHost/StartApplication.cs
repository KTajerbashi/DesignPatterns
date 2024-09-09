using NLog.Web;

namespace DesignPattern.EndPoint.API.AppHost;

public class StartApplication
{
    public static void RunApplication(Action action)
    {
        var logger = NLogBuilder.ConfigureNLog("NLog.config").GetCurrentClassLogger();
        try
        {
            logger.Info($"Application Started At {DateTime.Now}");
            action();

        }
        catch (Exception ex)
        {
            logger.Error(ex, "Stopped program because of exception");
            logger.Error($"Application Down At {DateTime.Now}");
            throw;
        }
        finally
        {
            logger.Info($"Application Shutdown At {DateTime.Now}");
            NLog.LogManager.Shutdown();
        }
    }
}
