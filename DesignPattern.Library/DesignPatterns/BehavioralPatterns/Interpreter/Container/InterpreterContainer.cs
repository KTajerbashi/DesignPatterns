using DesignPatterns.BehavioralPatterns.Interpreter.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        internal void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
