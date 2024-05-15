namespace DesignPatterns.TemplateMethod.Pattern
{
    public class Client
    {
        public static void Run(AbstractClass abstractClass)
        {
            abstractClass.TemplateMethod();
        }
    }

}
