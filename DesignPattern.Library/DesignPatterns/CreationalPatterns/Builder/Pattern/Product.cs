namespace DesignPatterns.CreationalPatterns.Builder.Pattern
{
    public class Product
    {
        public string PartA { get; set; }
        public string PartB { get; set; }
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name : {Name}");
            Console.WriteLine($"Product PartA : {PartA}");
            Console.WriteLine($"Product PartB : {PartB}");
        }
    }
}
