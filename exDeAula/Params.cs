using System;

class Calculadora
{
    public static int Soma(params int [] numeros)
    {
        int soma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            soma += numeros[i];
        }
        return soma;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int s1 = Calculadora.Soma(10, 78, 90)
                   
        Console.WriteLine(s1);
    }
}