using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vect[i] = new Produto { Name = name, Price = price };
            }

            double soma = 0;
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }

            double media = soma / n;
            Console.WriteLine("Media = " + media);
            
        } 
    }

    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}