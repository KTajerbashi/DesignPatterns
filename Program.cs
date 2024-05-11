﻿// See https://aka.ms/new-console-template for more information
using DesignPatterns.Factory.Services;
using DesignPatterns.Tools;

DesignConsole console = DesignConsole.DesignInstance();


console.Start("Application");
#region ProtoType
//#region ShalowCopy
//ConcreatePrototype ShalowCopy1 = new ConcreatePrototype(1500,"Prototype Pattern");

//ConcreatePrototype ShalowCopy2 = (ConcreatePrototype)ShalowCopy1.Clone();

//Console.WriteLine($"Service1 : {ShalowCopy1.Size}");
//Console.WriteLine($"Service2 : {ShalowCopy2.Size}");
//Console.WriteLine($"Result Equal : {ShalowCopy1 == ShalowCopy2}");
//#endregion

//#region DeepCopy
//ConcreatePrototype2 DeepCopyComplex1 = new ConcreatePrototype2(ShalowCopy1);
//var DeepCopyComplex2 = (ConcreatePrototype2)DeepCopyComplex1.Clone();

//Console.WriteLine($"Service1 : {DeepCopyComplex1.prototype1.Size}");
//Console.WriteLine($"Service1 : {DeepCopyComplex1.prototype1.Name}");
//Console.WriteLine($"Service2 : {DeepCopyComplex2.prototype1.Size}");
//Console.WriteLine($"Service2 : {DeepCopyComplex2.prototype1.Name}");
//Console.WriteLine($"Result Equal : {DeepCopyComplex1 == DeepCopyComplex2}");
//Console.WriteLine($"Result Equal : {DeepCopyComplex1 == DeepCopyComplex1}");

//#endregion
#endregion

#region Singleton

//Singleton singleton1 = Singleton.GetInstance();
//Singleton singleton2 = Singleton.GetInstance();
//Singleton singleton3 = Singleton.GetInstance();
//for (int i = 0; i < 10; i++)
//{
//    Singleton.GetInstance();
//}
//Console.WriteLine(singleton1 == singleton2);

#endregion

#region Factory
ConcreteCreator concreteCreator = new ConcreteCreator();
ISmsService mailService;
mailService = concreteCreator.FactoryMethod(CountryType.None);
mailService.Send(new MailDTO { Phone="09020320844",Email="Kaihan@mail.com",Message="Hello"});
mailService.GetMails();
mailService = concreteCreator.FactoryMethod(CountryType.Afghanistan);
mailService.Send(new MailDTO { Phone = "09024006014", Email = "Kamran@mail.com", Message = "Hello" });
mailService = concreteCreator.FactoryMethod(CountryType.Iran);
mailService.Send(new MailDTO { Phone = "09961514027", Email = "Tajer@mail.com", Message = "Hello" });
mailService = concreteCreator.FactoryMethod(CountryType.Turkey);
mailService.Send(new MailDTO { Phone = "09021001000", Email = "Tiger@mail.com", Message = "Hello" });
#endregion

console.End("Application");


Console.ReadLine();