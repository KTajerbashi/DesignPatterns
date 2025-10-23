namespace DesignPatterns.Behavioral.ChainOfResponsibility;

public abstract class Handler
{
    protected Handler? NextHandler;

    public void SetNext(Handler next)
    {
        NextHandler = next;
    }

    public abstract string Handle(int request);
}

public class Level1Handler : Handler
{
    public override string Handle(int request)
    {
        if (request <= 10)
        {
            return $"Level 1 handled request {request}";
        }
        return NextHandler?.Handle(request) ?? $"Request {request} unhandled";
    }
}

public class Level2Handler : Handler
{
    public override string Handle(int request)
    {
        if (request > 10 && request <= 20)
        {
            return $"Level 2 handled request {request}";
        }
        return NextHandler?.Handle(request) ?? $"Request {request} unhandled";
    }
}

public class Level3Handler : Handler
{
    public override string Handle(int request)
    {
        if (request > 20)
        {
            return $"Level 3 handled request {request}";
        }
        return NextHandler?.Handle(request) ?? $"Request {request} unhandled";
    }
}

