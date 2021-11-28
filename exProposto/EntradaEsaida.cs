using System;
using System.Globalization;

class EntradaEsaida
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo:");
        string nomeCompleto = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto:");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre com seu ultimo nome, idade e altura (mesma linha):");
        string[] completo = Console.ReadLine().Split(' ');
        string nome = completo[0];
        int idade = int.Parse(completo[1]);
        double altura = double.Parse(completo[2], CultureInfo.InvariantCulture);


        Console.WriteLine(nomeCompleto);
        Console.WriteLine(quartos);
        Console.WriteLine(preco);

        Console.WriteLine(nome);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
    }
}