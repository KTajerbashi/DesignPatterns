using DesignPatterns.Strategy.Examples.Sorting;
using DesignPatterns.Strategy.Pattern;
using DesignPatterns.Tools;
namespace DesignPatterns.Strategy.Container
{
    public class StrategyContainer
    {
        private DesignConsole Console;
        public StrategyContainer()
        {
            Console = DesignConsole.DesignInstance();
        }
        public void Pattern()
        {
            Console.ForeColor(ConsoleColor.DarkYellow);
            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();
            Console.ForeColor(ConsoleColor.Yellow);
            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();
            Console.ForeColor(ConsoleColor.Magenta);
            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();
        }
        public void Sorting()
        {
            var users = new User<long>[]
            {
                new User<long>{ Id=1,Name="User1",Email="User1@mail.com",Credit=25000 },
                new User<long>{ Id=3,Name="User3",Email="User3@mail.com",Credit=75000 },
                new User<long>{ Id=2,Name="User2",Email="User2@mail.com",Credit=50000 },
            };
            Console.ForeColor();
            Console.Section("Before Sorting");
            foreach (var item in users)
            {
                Console.ForeColor();
                item.DisplayModel();
                Console.ForeColor();
            }


            Console.Section("After Sorting");
            Array.Sort(users, new UserId_Compare());
            foreach (var item in users)
            {
                Console.ForeColor();
                item.DisplayModel();
                Console.ForeColor();
            }
        }
    }
}
