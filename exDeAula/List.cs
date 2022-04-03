using System;
using System.Collections.Generic;

public class Programa
{
	static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Marcos");
        list.Add("Joaquim");
        list.Insert(2, "Ana");
        list.Add("Joana");

        foreach ( string lista in list)
        {
            Console.WriteLine(lista);
        }

        Console.WriteLine("Contagem lista " + list.Count);


        string buscaPrimeiroDaCondicao = list.Find(x => x[0] == 'A');
        Console.WriteLine("Primeiro nome com A: " + buscaPrimeiroDaCondicao);


        string buscaUltimoDaCondicao = list.Find(x => x[0] == 'A');
        Console.WriteLine("Ultimo nome com A: " + buscaUltimoDaCondicao);


        int possicaoUm = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("Primeira posicao: " + possicaoUm);


        int possicaoDois = list.FindIndex(x => x[0] == 'A');
        Console.WriteLine("Primeira posicao: " + possicaoDois);

        Console.WriteLine("----------Filtro FindAll-------------------");

        List<string> list2 = list.FindAll(x => x.Length == 3);
        foreach(string obj in list2)
            Console.WriteLine(obj);


        Console.WriteLine("-----------------Remove--------------------");
        list.Remove("Joana");
        foreach (string lista in list)
        {
            Console.WriteLine(lista);
        }

        list.RemoveAll(x => x[0] == 'J')
        foreach (string lista in list)
        {
            Console.WriteLine(lista);
        }


        Console.WriteLine("-----------Remove pela posicao------------");
        list.RemoveAt(3);
        foreach (string lista in list)
        {
            Console.WriteLine(lista);
        }

        Console.WriteLine("-----------Remove a partir de------------");
        list.RemoveRange(2,2);
        foreach (string lista in list)
        {
            Console.WriteLine(lista);
        }
    }
}
