using System;

namespace EstoqueProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000, 15);

            p.Nome = "Video K7";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.GetPreco());
        }
    }
}
