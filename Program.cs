// See https://aka.ms/new-console-template for more information
using DesignPatterns.Extensions.Exceptions.Container;
using DesignPatterns.Extensions.Exceptions.Documentation.Examples;
using DesignPatterns.Extensions.Tools;

DesignConsole console = DesignConsole.DesignInstance();


console.Start("Application");


#region Command Pattern
console.ForeColor();
//CommandContainer command = new();
////command.Pattern();
//command.MailService();
#endregion

#region Exceptions
ExceptionContainer container = new();
container.CalculatorService.Divide();
#endregion
console.End("Application");


Console.ReadLine();