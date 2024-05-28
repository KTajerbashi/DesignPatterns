namespace DesignPatterns.Builder.Pattern
{
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
