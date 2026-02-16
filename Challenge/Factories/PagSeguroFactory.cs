using System;

public class PagSeguroFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateCardValidator() => new PagSeguroValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();

    public IPaymentLogger CreateTransactionLogger() => new PagSeguroLogger();
}

