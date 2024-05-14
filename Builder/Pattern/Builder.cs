namespace DesignPatterns.Builder.Pattern
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name : {this.Name}");
            Console.WriteLine($"Product PartA : {this.PartA}");
            Console.WriteLine($"Product PartB : {this.PartB}");
        }
    }

    public abstract class Builder
    {
        protected  Product Product;
        public Builder()
        {
            Product = new();
        }

        public abstract void BuildPartA();
        public abstract void BuildPartB();

        public virtual Product GetResult()
        {
            return Product;
        }

    }
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
    public class ConcreteBuilderB : Builder
    {
        public override void BuildPartA()
        {
            base.Product.PartA = "Part-A_A";
        }

        public override void BuildPartB()
        {
            base.Product.PartB = "Part-B_B";
        }
        public override Product GetResult()
        {
            Product.Name = "Product 1_1";
            Console.WriteLine($"{Product.Name} Created");
            return base.GetResult();
        }
    }
    
    public class Director
    {
        private Builder builder;
        public Director()
        {
            
        }
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }
        public void Constructor()
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
