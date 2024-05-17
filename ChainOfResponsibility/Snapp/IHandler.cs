namespace DesignPatterns.ChainOfResponsibility.Snapp
{
    public class RequestContext
    {
        public int UserId { get; set; }
        public Point Origin { get; set; }
        public Point Destination { get; set; }
    }
    public class ResponseContext
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
    public class Point
    {
        public double Lat { get; set; }
        public double Lang { get; set; }
    }
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        ResponseContext Execute(RequestContext context);
    }
    public abstract class TakeTaxiHandler : IHandler
    {
        protected IHandler Successor;

        public IHandler SetNext(IHandler handler)
        {
            this.Successor = handler;
            return Successor;
        }
        public abstract ResponseContext Execute(RequestContext context);
    }


    public class CreateOrder : TakeTaxiHandler
    {
        public override ResponseContext Execute(RequestContext context)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                if (Successor is not null)
                {
                    Console.WriteLine("Order Created ...");
                    return Successor.Execute(context);
                }
                else
                {
                    Console.WriteLine("Order Passed ...");
                    return new ResponseContext
                    {
                        IsSuccess = false,
                        Message = "Action Fail"
                    };
                }
            }
            else
            {
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "Action Fail"
                };
            }
        }
    }

    public class SendToDriver : TakeTaxiHandler
    {
        public override ResponseContext Execute(RequestContext context)
        {
            Console.WriteLine("Send To Driver");
            if (Successor is not null)
            {
                return Successor.Execute(context);
            }
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "Order Create and Send to Driver."
            };
        }
    }

    public class CheckActiveUser : TakeTaxiHandler
    {
        public override ResponseContext Execute(RequestContext context)
        {
            if (context.UserId > 0)
            {
                Console.WriteLine("Check Active User");
                if (Successor is not null)
                {
                    return Successor.Execute(context);
                }
                else
                {
                    return new ResponseContext
                    {
                        IsSuccess = false,
                        Message = "Action Fail"
                    };
                }
            }
            else
            {
                Console.WriteLine("User Not Found");
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "User is Not Active."
                };
            }
        }
    }
    public class CheckTest : TakeTaxiHandler
    {
        public override ResponseContext Execute(RequestContext context)
        {
           Console.WriteLine("CheckTest is done");
            if (Successor is not null)
            {
                return Successor.Execute(context);
            }
            else
            {
                return new ResponseContext
                {
                    IsSuccess = false,
                    Message = "Action Fail"
                };
            }
        }
    }
}
