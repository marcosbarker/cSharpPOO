/*
 * Fazer um programa para ler um número inteiro N e uma matriz de
ordem N contendo números inteiros. Em seguida, mostrar a diagonal
principal e a quantidade de valores negativos da matriz.
*/ 
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Qual tamanho da matriz quadrada? ");

        int n = int.Parse(Console.ReadLine());

        int[,] matriz = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(valores[j]);
            }

            Console.WriteLine("Diagonal da matriz:");

            for( int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(matriz[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Numeros negativos " + count);
        }
    }
}