// DESAFIO: Sistema de Pagamentos Multi-Gateway
// PROBLEMA: Uma plataforma de e-commerce precisa integrar com múltiplos gateways de pagamento
// (PagSeguro, MercadoPago, Stripe) e cada gateway tem componentes específicos (Processador, Validador, Logger)
// O código atual está muito acoplado e dificulta a adição de novos gateways

using System;

namespace DesignPatternChallenge
{
    // Contexto: Sistema de pagamentos que precisa trabalhar com diferentes gateways
    // Cada gateway tem sua própria forma de processar, validar e logar transações

    class Program
    {
        static void Main(string[] args)
        {
            ExecuteMercadoPagoPayment();

            ExecutePagSeguroPayment();

            ExecuteStripePayment();
        }

        public static void ExecutePagSeguroPayment()
        {
            Console.WriteLine("Payment initiated with PagSeguro...");

            IPaymentGatewayFactory pagSeguroFactory = new PagSeguroFactory();
            var pagSeguroService = new PaymentService(pagSeguroFactory);

            string cardNumber = "1234567890123456";
            decimal amount = 500.00m;

            pagSeguroService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via PagSeguro...");
            Console.WriteLine("-----------------------------------");
        }

        public static void ExecuteMercadoPagoPayment()
        {
            Console.WriteLine("Payment initiated with MercadoPago...");

            IPaymentGatewayFactory mercadoPagoFactory = new MercadoPagoFactory();
            var mercadoPagoService = new PaymentService(mercadoPagoFactory);

            string cardNumber = "5234567890123456";
            decimal amount = 200.00m;

            mercadoPagoService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via MercadoPago...");
            Console.WriteLine("-----------------------------------");
        }

        public static void ExecuteStripePayment()
        {
            Console.WriteLine("Payment initiated with Stripe...");

            IPaymentGatewayFactory stripeFactory = new StripeFactory();
            var stripeService = new PaymentService(stripeFactory);

            string cardNumber = "4234567890123456";
            decimal amount = 2500.00m;

            stripeService.ProcessPayment(amount, cardNumber);

            Console.WriteLine("Payment completed via Stripe...");
            Console.WriteLine("-----------------------------------");
        }
    }
}
