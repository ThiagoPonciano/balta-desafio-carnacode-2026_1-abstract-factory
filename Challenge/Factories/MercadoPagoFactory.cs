using System;

public class MercadoPagoFactory : IPaymentGatewayFactory
{
    public IPaymentValidator CreateCardValidator() => new MercadoPagoValidator();

    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();

    public IPaymentLogger CreateTransactionLogger() => new MercadoPagoLogger();
}
