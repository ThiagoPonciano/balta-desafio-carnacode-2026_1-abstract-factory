using System;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public ICardValidator CreateCardValidator() => new MercadoPagoValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();

    public ITransactionLogger CreateTransactionLogger() => new MercadoPagoLogger();
}
