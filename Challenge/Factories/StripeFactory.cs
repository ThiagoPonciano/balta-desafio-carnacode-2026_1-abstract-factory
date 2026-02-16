using System;

public class StripeFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateCardValidator() => new StripeValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();

    public IPaymentLogger CreateTransactionLogger() => new StripeLogger();
}
