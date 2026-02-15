using System;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
