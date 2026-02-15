using System;

public class StripeValidator : ICardValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("Stripe: Validating card...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("4");
    }
}
