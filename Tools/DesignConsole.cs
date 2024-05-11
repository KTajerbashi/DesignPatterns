namespace DesignPatterns.Tools
{
    public class DesignConsole
    {
        private static readonly  Lazy<DesignConsole> Design = new Lazy<DesignConsole>(() => new DesignConsole());
        private DesignConsole()
        {
            Console.Title = "Design Pattern";
        }
        
        public static DesignConsole DesignInstance()
        {
            return Design.Value;
        }



        public void Background(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void ForeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void NewLine()
        {
            Console.WriteLine("\n");
        }
        public void Section()
        {
            Console.WriteLine("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
        }
        public void Title(string title)
        {
            Console.WriteLine($"\n== == == == == == {title} == == == == == ==\n");
        }
        public void Start(string title)
        {
            ForeColor(ConsoleColor.Black);
            Background(ConsoleColor.Red);
            Console.WriteLine("======================================================");
            Console.WriteLine($"== == == == Start Of {title} \t");
            Console.WriteLine("======================================================");
            Background(ConsoleColor.Black);
        }
        public void End(string title)
        {
            ForeColor(ConsoleColor.Black);
            Background(ConsoleColor.Red);
            Console.WriteLine("======================================================");
            Console.WriteLine($"== == == == End Of {title} \t");
            Console.WriteLine("======================================================");
            Background(ConsoleColor.Black);
            Section();
        }
    }

}
