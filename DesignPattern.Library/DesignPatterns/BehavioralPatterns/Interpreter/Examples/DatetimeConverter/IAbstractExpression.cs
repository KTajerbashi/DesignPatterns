namespace DesignPatterns.BehavioralPatterns.Interpreter.Examples.DatetimeConverter
{
    public interface IAbstractExpression
    {
        void Interpret(DatetimeInterpreter interpreter);
    }
    public class YearExpression : IAbstractExpression
    {
        public void Interpret(DatetimeInterpreter interpreter)
        {
            string expression = interpreter.Expression;
            interpreter.Expression = expression.Replace("YYYY", interpreter.DateTime.Year.ToString());
        }
    }
    public class MonthExpression : IAbstractExpression
    {
        public void Interpret(DatetimeInterpreter interpreter)
        {
            string expression = interpreter.Expression;
            interpreter.Expression = expression.Replace("MM", interpreter.DateTime.Month.ToString());
        }
    }
    public class DayExpression : IAbstractExpression
    {
        public void Interpret(DatetimeInterpreter interpreter)
        {
            string expression = interpreter.Expression;
            interpreter.Expression = expression.Replace("DD", interpreter.DateTime.Day.ToString());
        }
    }

    public class YearShortExpression : IAbstractExpression
    {
        public void Interpret(DatetimeInterpreter interpreter)
        {
            string expression = interpreter.Expression;
            interpreter.Expression = expression.Replace("YY", interpreter.DateTime.Year.ToString().Substring(2,2));
        }
    }
}
