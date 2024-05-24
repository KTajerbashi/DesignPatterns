namespace DesignPatterns
{
    public class MainApplication
    {
        public static void Execute(string key)
        {
            switch(key)
            {
                case "1":
                    {
                        Console.WriteLine("Singleton");
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Factory");
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Abstract Factory");
                        break;
                    }
                case "4":
                    {
                        Console.WriteLine("Builder");
                        break;
                    }
                case "5":
                    {
                        Console.WriteLine("Prototype");
                        break;
                    }
                case "6":
                    {
                        Console.WriteLine("Adapter");
                        break;
                    }
                case "7":
                    {
                        Console.WriteLine("Bridge");
                        break;
                    }
                case "8":
                    {
                        Console.WriteLine("Composite");
                        break;
                    }
                case "9":
                    {
                        Console.WriteLine("Decorator");
                        break;
                    }
                case "10":
                    {
                        Console.WriteLine("Facade");
                        break;
                    }
                case "11":
                    {
                        Console.WriteLine("Flyweight");
                        break;
                    }
                case "12":
                    {
                        Console.WriteLine("Proxy");
                        break;
                    }
                case "cls":
                case "CLS":
                    {
                        Console.Clear();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Key");
                        break;
                    }
            }
        }
    }
}
