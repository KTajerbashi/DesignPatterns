using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Client.Services;
using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Objector;
using DesignPatterns.BehavioralPatterns.Visitor.Example.TaxiServices.Services;
using DesignPatterns.BehavioralPatterns.Visitor.Pattern;
using DesignPatterns.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Visitor.Container
{
    public class VisitorContainer
    {
        private readonly DesignConsole designConsole = DesignConsole.DesignInstance();
        public VisitorContainer()
        {
            
        }
        public void Pattern()
        {
            ConcreteElementA elementAA = new ("ElementA A 1");
            ConcreteElementA elementAB = new ("ElementA B 1");
            ConcreteElementA elementAC = new ("ElementA C 1");
            ConcreteElementA elementAD = new ("ElementA D 1");
            ConcreteElementA elementAE = new ("ElementA E 1");
            ConcreteElementA elementAF = new ("ElementA F 1");
            ConcreteElementA elementAG = new ("ElementA G 1");


            ConcreteElementB elementBA = new ("ElementB A 1");
            ConcreteElementB elementBB = new ("ElementB B 1");
            ConcreteElementB elementBC = new ("ElementB C 1");
            ConcreteElementB elementBD = new ("ElementB D 1");
            ConcreteElementB elementBE = new ("ElementB E 1");
            ConcreteElementB elementBF = new ("ElementB F 1");
            ConcreteElementB elementBG = new ("ElementB G 1");


            ObjectStructure objectStructure = new ObjectStructure();
            objectStructure.Add(elementAA);
            objectStructure.Add(elementAB);
            objectStructure.Add(elementAC);
            objectStructure.Add(elementAD);
            objectStructure.Add(elementAE);
            objectStructure.Add(elementAF);
            objectStructure.Add(elementAG);
            objectStructure.Add(elementBA);
            objectStructure.Add(elementBB);
            objectStructure.Add(elementBC);
            objectStructure.Add(elementBD);
            objectStructure.Add(elementBE);
            objectStructure.Add(elementBF);
            objectStructure.Add(elementBG);

            ConcreteVisitorA visitorA = new();
            designConsole.ForeColor();
            objectStructure.Accept(visitorA);
            designConsole.ForeColor();
            Console.WriteLine("====================================================");
            designConsole.ForeColor();
            ConcreteVisitorB visitorB = new();
            objectStructure.Accept(visitorB);
            designConsole.ForeColor();
        }

        public void Taxi()
        {
            OlaService olaA = new("Driver1","Customer1");
            OlaService olaB = new("Driver2","Customer2");
            OlaService olaC = new("Driver3","Customer3");
            SnappService snappA = new("Driver1","Customer1");
            SnappService snappB = new("Driver2","Customer2");
            SnappService snappC = new("Driver3","Customer3");
            PersonalTaxiService personalTaxiA = new("Driver1","Customer1");
            PersonalTaxiService personalTaxiB = new("Driver2","Customer3");
            PersonalTaxiService personalTaxiC = new("Driver3","Customer3");
            ObjectStructureTaxi objectStructure = new ObjectStructureTaxi();
            objectStructure.Add(olaA);
            objectStructure.Add(olaB);
            objectStructure.Add(olaC);
            objectStructure.Add(snappA);
            objectStructure.Add(snappB);
            objectStructure.Add(snappC);
            objectStructure.Add(personalTaxiA);
            objectStructure.Add(personalTaxiB);
            objectStructure.Add(personalTaxiC);

            ConcreteVisitTaxiOla OlaVisitor = new();
            ConcreteVisitTaxiPersonal PersonalVisitor = new();
            ConcreteVisitTaxiSnapp SnappVisitor = new();
            Console.WriteLine("====================================================");
            designConsole.ForeColor();
            objectStructure.Accept(OlaVisitor);
            Console.WriteLine("====================================================");
            designConsole.ForeColor();
            objectStructure.Accept(PersonalVisitor);
            Console.WriteLine("====================================================");
            designConsole.ForeColor();
            objectStructure.Accept(SnappVisitor);



        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
