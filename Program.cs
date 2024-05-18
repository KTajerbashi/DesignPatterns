// See https://aka.ms/new-console-template for more information
using DesignPatterns.Commands.Container;
using DesignPatterns.Tools;

DesignConsole console = DesignConsole.DesignInstance();


console.Start("Application");


#region Command Pattern
console.ForeColor();
CommandContainer command = new();
//command.Pattern();
command.MailService();
#endregion


console.End("Application");


Console.ReadLine();