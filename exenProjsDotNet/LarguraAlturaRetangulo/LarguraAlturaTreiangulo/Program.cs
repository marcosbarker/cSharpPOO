using System;

namespace LarguraAlturaTreiangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo:");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(r);
        }
    }
}
