using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaMovimentacao cm;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Havera deposito inicial (s/n): ");
            char resposta = char.Parse(Console.ReadLine());
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Entre com o valor de deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                cm = new ContaMovimentacao(numero, titular, depositoInicial);
            }
            else
            {
                cm = new ContaMovimentacao(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cm);

            Console.WriteLine();

            Console.Write("Entre com um valor para depostito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cm.Deposito(deposito);

            Console.WriteLine();

            Console.Write("Dados atualizados: ");
            Console.WriteLine(cm);

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cm.Saque(saque);

            Console.WriteLine();

            Console.Write("Dados atualizados: ");
            Console.WriteLine(cm);
        }
    }
}
