using System;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}
