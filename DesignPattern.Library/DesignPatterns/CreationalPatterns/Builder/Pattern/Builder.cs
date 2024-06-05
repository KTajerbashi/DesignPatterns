namespace DesignPatterns.CreationalPatterns.Builder.Pattern
{

    public abstract class Builder
    {
        protected Product Product;
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
}
