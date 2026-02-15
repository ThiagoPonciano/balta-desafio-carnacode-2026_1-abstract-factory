using System;

public class StripeFactory : IPaymentGatewayFactory
{
    public ICardValidator CreateCardValidator() => new StripeValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();

    public ITransactionLogger CreateTransactionLogger() => new StripeLogger();
}
