using DesignPatterns.Extensions.Exceptions.CustomExceptions;
using System.Net;

namespace DesignPatterns.Extensions.Exceptions.Wrapper;

/// <summary>
/// 
/// </summary>
public class WrapperContainer
{
    private readonly WebClient client;
    public WrapperContainer()
    {
        client = new();
    }
    public void CallWebService()
    {
        try
        {
            var result = client.DownloadString("");
        }
        catch (WebClientException ex)
        {
            throw new WebClientException(ex.Message, ex);
        }
    }
}
