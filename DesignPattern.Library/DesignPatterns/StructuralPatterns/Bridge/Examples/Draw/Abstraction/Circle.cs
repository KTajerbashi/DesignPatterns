using DesignPatterns.StructuralPatterns.Bridge.Examples.Draw.Implementation;

namespace DesignPatterns.StructuralPatterns.Bridge.Examples.Draw.Abstraction
{
    public class Circle : Shape
    {
        private float radius;
        public Circle(IRenderer renderer, float radius) : base(renderer)
        {
            this.radius = radius;
        }
        public override void Draw()
        {
            renderer.RenderCircle(radius);
        }
    }


}
