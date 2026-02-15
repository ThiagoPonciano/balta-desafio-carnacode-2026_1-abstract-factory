using System;

public interface IPaymentGatewayFactory
{
    ICardValidator CreateCardValidator();
    IPaymentProcessor CreatePaymentProcessor();
    ITransactionLogger CreateTransactionLogger();
}
