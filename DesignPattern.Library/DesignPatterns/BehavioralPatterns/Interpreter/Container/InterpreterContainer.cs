using DesignPatterns.BehavioralPatterns.Interpreter.Examples.DatetimeConverter;
using DesignPatterns.BehavioralPatterns.Interpreter.Pattern;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Container
{
    public class InterpreterContainer
    {
        public void Pattern()
        {
            Context context = new Context();
            List<AbstractExpression> abstractExpressions = new List<AbstractExpression>();

            abstractExpressions.Add(new TerminalExpression());
            abstractExpressions.Add(new NonTerminalExpression());
            abstractExpressions.Add(new TerminalExpression());
            abstractExpressions.Add(new TerminalExpression());
            abstractExpressions.Add(new NonTerminalExpression());
            abstractExpressions.Add(new TerminalExpression());
            abstractExpressions.Add(new NonTerminalExpression());
            abstractExpressions.Add(new TerminalExpression());
            abstractExpressions.Add(new NonTerminalExpression());

            foreach (var item in abstractExpressions)
            {
                item.Interpret(context);
            }
        }
        public string DatetimeInterpreterExecute(string input)
        {
            List<IAbstractExpression> expressions = new List<IAbstractExpression>();
            DatetimeInterpreter datetime = new DatetimeInterpreter(DateTime.Now);
            while (true)
            {
                Console.WriteLine("Select Mode Datetime Format By : YYYY - MM - DD - YY");
                datetime.Expression = input.ToUpper();
                string[] format = datetime.Expression.Split(' ');
                foreach (var item in format)
                {
                    switch (item)
                    {
                        case "YYYY":
                            {
                                expressions.Add(new YearExpression());
                                break;
                            }
                        case "MM":
                            {
                                expressions.Add(new MonthExpression());
                                break;
                            }
                        case "DD":
                            {
                                expressions.Add(new DayExpression());
                                break;
                            }
                        case "YY":
                            {
                                expressions.Add(new YearShortExpression());
                                break;
                            }
                        case "":
                        default:
                            {
                                break;
                            }
                    }
                }
                foreach (var item in expressions)
                {
                    item.Interpret(datetime);
                }
                return datetime.Expression;
            }
        }
    }
}
