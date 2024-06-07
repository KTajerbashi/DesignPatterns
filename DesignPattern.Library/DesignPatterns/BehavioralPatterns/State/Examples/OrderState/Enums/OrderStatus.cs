namespace DesignPatterns.BehavioralPatterns.State.Examples.OrderState.Enums
{
    public enum OrderStatus : byte
    {
        Unknown = 0,
        Waiting_To_Send,
        Sent,
        Delivered,
        Canceled

    }
}
