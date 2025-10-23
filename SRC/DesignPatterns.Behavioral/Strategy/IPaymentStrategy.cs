namespace DesignPatterns.Behavioral.Strategy;

public interface IPaymentStrategy
{
    string Pay(decimal amount);
}
public class CreditCardPayment : IPaymentStrategy
{
    public string Pay(decimal amount)
    {
        return $"💳 Paid {amount:C} using Credit Card.";
    }
}
public class PayPalPayment : IPaymentStrategy
{
    public string Pay(decimal amount)
    {
        return $"💻 Paid {amount:C} via PayPal.";
    }
}
public class CryptoPayment : IPaymentStrategy
{
    public string Pay(decimal amount)
    {
        return $"🪙 Paid {amount:C} using Cryptocurrency.";
    }
}
public class PaymentContext
{
    private IPaymentStrategy _strategy;

    public void SetStrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public string ExecutePayment(decimal amount)
    {
        if (_strategy == null)
            return "❌ Please select a payment method.";

        return _strategy.Pay(amount);
    }
}