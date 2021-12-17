using System;

namespace EstoqueAutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
