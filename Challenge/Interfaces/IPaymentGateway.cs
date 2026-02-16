using System;

public interface IPaymentGatewayFactory
{
    IPaymentValidator CreateCardValidator();
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentLogger CreateTransactionLogger();
}
