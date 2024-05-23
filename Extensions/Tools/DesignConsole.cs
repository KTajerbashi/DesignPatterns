using System;

namespace DesignPatterns.Extensions.Tools
{
    public class DesignConsole
    {
        private static readonly Lazy<DesignConsole> Design = new Lazy<DesignConsole>(() => new DesignConsole());
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
        public void Section(string title = "")
        {
            Console.WriteLine($"\n:: :: :: :: :: {title} :: :: :: :: ::\n");
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

        public void ForeColor()
        {
            var random = new Random();
            ForeColor((ConsoleColor)random.Next((int)ConsoleColor.Black + 1, (int)ConsoleColor.Yellow));
            random.Next();

        }
    }

}
