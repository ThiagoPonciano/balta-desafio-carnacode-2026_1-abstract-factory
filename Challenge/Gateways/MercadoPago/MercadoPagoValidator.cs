using System;

public class MercadoPagoValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("MercadoPago: Validating card...");
        return cardNumber.Length == 16 && cardNumber.StartsWith("5");
    }
}
