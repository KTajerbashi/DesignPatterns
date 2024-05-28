using DesignPattern.EndPoint.API.Exceptions.CustomExceptions;
using System.Net;

namespace DesignPattern.EndPoint.API.Exceptions.Wrapper;

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
