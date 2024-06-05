namespace DesignPatterns.CreationalPatterns.Builder.Pattern
{
    public class ConcreteBuilderB : Builder
    {
        public override void BuildPartA()
        {
            Product.PartA = "Part-A_A";
        }

        public override void BuildPartB()
        {
            Product.PartB = "Part-B_B";
        }
        public override Product GetResult()
        {
            Product.Name = "Product 1_1";
            Console.WriteLine($"{Product.Name} Created");
            return base.GetResult();
        }
    }
}
