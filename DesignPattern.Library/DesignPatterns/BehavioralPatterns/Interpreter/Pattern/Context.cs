namespace DesignPatterns.BehavioralPatterns.Interpreter.Pattern
{
    public  class Context
    {
    }

    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }
    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("TerminalExpression.Interpret(context)");
        }
    }
    /// <summary>
    /// طراحی درختی ازین میتوانیم استفاده کنیم
    /// </summary>
    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("NonTerminalExpression.Interpret(context)");
        }
    }
}
