using System;

public class PagSeguroValidator : ICardValidator
{
    public bool ValidateCard(string cardNumber)
    {
        Console.WriteLine("PagSeguro: Validating card...");
        return cardNumber.Length == 16;
    }
}
