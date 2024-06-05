namespace DesignPatterns.StructuralPatterns.Proxy.Pattern
{
    public class Proxy : Subject
    {
        private RealSubject Subject;
        public override void Execute()
        {
            RealSubject().Execute();
        }
        protected RealSubject RealSubject()
        {
            if (Subject is null)
            {
                Subject = new RealSubject();
            }
            return Subject;
        }
    }
}
