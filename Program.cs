// See https://aka.ms/new-console-template for more information
using DesignPatterns.Extentions.Exceptions.Documentation.Examples;
using DesignPatterns.Extentions.Tools;

DesignConsole console = DesignConsole.DesignInstance();


console.Start("Application");


#region Command Pattern
console.ForeColor();
//CommandContainer command = new();
////command.Pattern();
//command.MailService();
#endregion

#region Exceptions

#region Comments
//UsageErrorsExceptions usageErrorsExceptions = new ();
//usageErrorsExceptions.Execute(3);
//ProgramErrorsExceptions programErrorsExceptions = new ();
//programErrorsExceptions.Execute("A");
//SystemFailuresExceptions systemFailuresExceptions = new ();
//systemFailuresExceptions.Execute("B");
//ApiInvokerService apiInvokerService = new ();
//apiInvokerService.Exceute();
#endregion
CalcualtorService calcualtor = new();

#region Stack Trace
//calcualtor.StackTraceFun(10,0);
#endregion

#region Data
//try
//{
//    calcualtor.DataExceptionFun("Ali");
//}
//catch (Exception ex)
//{
//    if (ex.Data.Count > 0)
//    {
//        foreach (DictionaryEntry item in ex.Data)
//        {
//            Console.WriteLine($"{item.Key} : {item.Value}");
//        }
//    }
//	//throw;
//}
#endregion

#region Inner Exception
//  Inner Exception
//try
//{
//    calcualtor.InnerException("ds");
//}
//catch (Exception ex)
//{
//    Exception innerExc = ex.InnerException;
//    while (innerExc != null)
//    {
//        Console.WriteLine($"{innerExc.Message}");
//        innerExc = innerExc.InnerException;
//    }
//    throw;
//}
#endregion

#region CustomeException
try
{
    calcualtor.SumNumbers(1, 2, "/");
}
catch
{
    throw;
}
#endregion
#endregion


console.End("Application");


Console.ReadLine();