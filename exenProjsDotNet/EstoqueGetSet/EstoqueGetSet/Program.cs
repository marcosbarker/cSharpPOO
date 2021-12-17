using System;

namespace EstoqueGetSet
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 1000, 10);

            p.SetNome("V");
            Console.WriteLine(p.GetNome());            
        }
    }
}
