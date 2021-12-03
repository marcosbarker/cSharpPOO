using System;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto " + p);
            Console.WriteLine();

            Console.Write("Numero de produtos a serem adicionados: ");
            int quantidade = int.Parse(Console.ReadLine());
            p.AddEstoque(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


            Console.Write("Numero de produtos a serem removidos: ");
            quantidade = int.Parse(Console.ReadLine());
            p.SubEstoque(quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
