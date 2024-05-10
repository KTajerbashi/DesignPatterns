using DesignPatterns.Bridge.Draw.Implementation;

namespace DesignPatterns.Bridge.Draw.Abstraction
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
