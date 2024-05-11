using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype.Pattern
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
    public class ConcreatePrototype : IPrototype
    {
        public int Size { get; set; }
        public string? Name { get; set; }

        public ConcreatePrototype(int size, string? name)
        {
            Size = size;
            Name = name;
        }

        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
    public class ConcreatePrototype2 : IPrototype
    {
        public ConcreatePrototype prototype1 { get; set; }
        public ConcreatePrototype2(ConcreatePrototype prototype1)
        {
            this.prototype1 = prototype1;
        }
        public IPrototype Clone()
        {
            var result = (ConcreatePrototype2)this.MemberwiseClone();
            result.prototype1 = (ConcreatePrototype)this.prototype1.Clone();
            return (IPrototype)result;
        }
    }
}
