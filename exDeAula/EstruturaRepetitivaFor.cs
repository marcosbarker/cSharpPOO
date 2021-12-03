using System;

class EstruturaRepetitivaFor
{
    static void Main(String[] args)
    {
        int soma = 0;

        Console.Write("Quantos numeros inteiros voce vai digitar: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Valor #{0}: ", i);
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
        Console.WriteLine("Soma = " + soma);
    }
}