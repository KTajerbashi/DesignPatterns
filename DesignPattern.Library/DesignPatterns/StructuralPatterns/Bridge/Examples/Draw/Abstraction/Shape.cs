using DesignPatterns.StructuralPatterns.Bridge.Examples.Draw.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns.Bridge.Examples.Draw.Abstraction
{
    public abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }
        public abstract void Draw();
    }


}
