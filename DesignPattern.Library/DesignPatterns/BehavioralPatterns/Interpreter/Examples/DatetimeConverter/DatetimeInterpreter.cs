using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

namespace DesignPatterns.BehavioralPatterns.Interpreter.Examples.DatetimeConverter
{
    public class DatetimeInterpreter
    {
        public string Expression { get; set; }
        public DateTime DateTime { get; set; }

        public DatetimeInterpreter(DateTime dateTime)
        {
            DateTime = dateTime;
        }
    }
}
