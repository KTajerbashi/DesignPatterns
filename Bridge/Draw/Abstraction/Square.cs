using DesignPatterns.Bridge.Draw.Implementation;

namespace DesignPatterns.Bridge.Draw.Abstraction
{
    public class Square : Shape
    {
        private float side;
        public Square(IRenderer renderer, float side) : base(renderer)
        {
            this.side = side;
        }
        public override void Draw()
        {
            renderer.RenderSquare(side);
        }
    }


}
