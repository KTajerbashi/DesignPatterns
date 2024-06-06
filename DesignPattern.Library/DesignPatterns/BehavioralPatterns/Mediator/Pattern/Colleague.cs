namespace DesignPatterns.BehavioralPatterns.Mediator.Pattern
{
    public abstract class Colleague
    {
        protected Mediator mediator;
        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.NotifyChange(message, this);
        }
    }

}
