using DesignPatterns.Extentions.Tools;
using System.Net;

namespace DesignPatterns.Extentions.Exceptions.Documentation.Examples
{
    public class ApiInvokerService
    {
        private DesignConsole DesignConsole;
        public ApiInvokerService()
        {
            DesignConsole = DesignConsole.DesignInstance();
        }
        public void Exceute()
        {
            DesignConsole.ForeColor();
            WebClient webClient = new();
            try
            {
                var result = webClient.DownloadString("https://adsinternet.ir");
                //var result = webClient.DownloadString("https://google.com");
                var data = result;
                Console.WriteLine($@"{result}");
            }
            catch (WebException ex) when (ex.Status != WebExceptionStatus.ProtocolError)
            {
                Console.WriteLine("WebExceptionStatus.ProtocolError");
                throw;
            }
            catch (WebException ex) when ((ex.Response as HttpWebResponse)?.StatusCode == HttpStatusCode.InternalServerError)
            {
                Console.WriteLine("HttpStatusCode.InternalServerError");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex}");
                throw;
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}
