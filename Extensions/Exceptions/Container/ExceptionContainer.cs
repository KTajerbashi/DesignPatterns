using DesignPatterns.Extensions.Exceptions.CustomExceptions;
using DesignPatterns.Extensions.Exceptions.Documentation.Examples;
using DesignPatterns.Extensions.Exceptions.Wrapper;

namespace DesignPatterns.Extensions.Exceptions.Container
{
    public class ExceptionContainer
    {
        public WrapperContainer WrapperContainer { get; set; }
        public CalculatorService CalculatorService { get; set; }
        public ExceptionContainer()
        {
            CalculatorService = new();
            WrapperContainer = new();
        }

        public void CallWebService()
        {
            try
            {
                WrapperContainer.CallWebService();
            }
            catch (WebClientException ex)
            {
                throw new WebClientException(ex.Message, ex);
            }
        }
    }
}
