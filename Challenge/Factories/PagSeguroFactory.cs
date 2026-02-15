using System;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public ICardValidator CreateCardValidator() => new PagSeguroValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();

    public ITransactionLogger CreateTransactionLogger() => new PagSeguroLogger();
}

