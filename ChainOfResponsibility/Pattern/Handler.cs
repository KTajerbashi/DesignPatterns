namespace DesignPatterns.ChainOfResponsibility.Pattern
{
    public abstract class Handler
    {
        protected Handler Successor;
        public void SetSuccessor(Handler successor)
        {
            this.Successor = successor;
        }
        public abstract void HandleRequest(int request);
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request < 50)
            {
                Console.WriteLine($"ConcreteHandler A .HandleRequest() Handled : {request}...");
            }
            else if (Successor is not null)
            {
                base.Successor.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 50)
            {
                Console.WriteLine($"ConcreteHandler B .HandleRequest() Handled : {request}...");
            }
            else if (Successor is not null)
            {
                base.Successor.HandleRequest(request);
            }
        }
    }
}
