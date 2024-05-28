namespace DesignPatterns.Strategy.Examples.Sorting
{
    public class User<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Credit { get; set; }
        public void DisplayModel()
        {
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Email : {Email}");
            Console.WriteLine($"Credit : {Credit}");
        }
    }
}
