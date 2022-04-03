using System;

public class Program
{
	public static void Main(string[] args)
	{
		double[,] matriz = new double[2, 3];

        Console.WriteLine(matriz.Length); //campos totais
        Console.WriteLine(matriz.Rank);   //quantidade de linhas
        Console.WriteLine(matriz.GetLength(0)); //tamanho primeira dimensao
		Console.WriteLine(matriz.GetLength(1)); //tamanho segunda dimensao       
	}
}
