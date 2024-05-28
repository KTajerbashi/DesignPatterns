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
}
