using System;

public class Estudante
{
	public string Nome { get; set; }
	public string Email { get; set; }

	public Estudante(string nome, string email)
    {
		Nome = nome;
		Email = email;
    }

    public override string ToString()
    {
        return Nome + ", " + Email;
    }
}


public class Programa
{
    static void Main(string[] args)
    {
        Estudante[] vetor = new Estudante[10];

        Console.WriteLine("Quantos quartos serao alugados? ");
        int n = int.Parse(Console.ReadLine());

        for(int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Aluguel #{0}", n);
            
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            vetor[quarto] = new Estudante(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");

        for( int i = 0; i < 10; i++)
        {
            if (vetor[i] != null)
            {
                Console.WriteLine(" " + i + ": " + vetor[i]);
            }
        }
    }
}
