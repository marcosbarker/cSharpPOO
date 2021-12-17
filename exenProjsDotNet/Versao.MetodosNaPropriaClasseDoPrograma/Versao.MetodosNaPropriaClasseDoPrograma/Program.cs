using System;

namespace Versao.MetodosNaPropriaClasseDoPrograma
{
    class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circunferencia);
            Console.WriteLine("Volume: " + volume);
            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3.0);
        }
    }
}
