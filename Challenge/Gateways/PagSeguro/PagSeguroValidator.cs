using System;

public class PagSeguroValidator : IPaymentValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validating card...");
        return cardNumber.Length == 16;
    }
}
