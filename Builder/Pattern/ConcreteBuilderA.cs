namespace DesignPatterns.Builder.Pattern
{
    public class ConcreteBuilderA : Builder
    {
        public override void BuildPartA()
        {
            base.Product.PartA = "Part-A";
        }

        public override void BuildPartB()
        {
            base.Product.PartB = "Part-B";
        }
        public override Product GetResult()
        {
            Product.Name = "Product 1";
            Console.WriteLine($"{Product.Name} Created");
            return base.GetResult();
        }
    }
}
