﻿namespace DesignPatterns.BehavioralPatterns.Visitor.Pattern;

public class ConcreteElementB : Element
{
    public string OrderId { get; private set; }

    public ConcreteElementB(string orderId)
    {
        this.OrderId = orderId;
    }
    public override void Accept(Visitor visitor)
    {
        visitor.VisitConcreteElementB(this);
    }
}