using System;

class Programa
{
    static void Main(string[] argas)
    {
        string[] vetor = new string[] {"Marcos", "Ana", "Joaquim" };

        foreach(string nomes in vetor)
        {
            Console.WriteLine(nomes);
        }


        /*
        for (int i = 0; i < vetor.Length; i++)
            Console.WriteLine(vetor[i]);
        */
    }
}