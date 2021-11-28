using System;

namespace exDeAula
{
    class EntradaDeDados
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine(); ou
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];


            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
        }
    }
}