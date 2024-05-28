﻿using DesignPatterns.Bridge.Pattern.Implementors;

namespace DesignPatterns.Bridge.Pattern.Abstractions
{
    public abstract class AbstractionClass
    {
        private ImplementorClass implementorClass;

        protected AbstractionClass()
        {
            implementorClass = new ConcreteImplementor();
        }

        public virtual void Function()
        {
            implementorClass.Implementation();
        }
    }
    public class RefinedAbstractionClass : AbstractionClass
    {

    }
}
