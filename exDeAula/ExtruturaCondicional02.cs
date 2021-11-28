using System;

class ExtruturaCondicional02
{
    static void Main(string[] args)
    {

        Console.WriteLine("Qual a hora atual?");
        int hora = int.Parse(Console.ReadLine());

        //string datetime = DateTime.Now.ToString("T");

        if (hora < 12)
        {
            Console.WriteLine("Bom dia");
        }
        else if (hora < 18)
        {
            Console.WriteLine("Boa tarde");
        }
        else
        {
            Console.WriteLine("Boa noite");
        }
    }
}
