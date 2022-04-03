using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroFuncionarios
{
	class Funcionario
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Salario { get; private set; }

		public Funcionario(int id, string name, double salario)
		{
			Id = id;
			Name = name;
			Salario = salario;
		}

		public void AumentoDeSalario(double aumento)
		{
			Salario += Salario * aumento / 100.0;
		}

		public override string ToString()
		{
			return Id
			+ ", "
			+ Name
			+ ", "
			+ Salario.ToString("F2", CultureInfo.InvariantCulture);
		}
	}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios quer cadastrar?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("Empregado #" + i + ":");

                Console.WriteLine("id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Escolha o funcionario que tera aumento salarial: ");
            int procuraId = int.Parse(Console.ReadLine());

            Funcionario empresa = list.Find(x => x.Id == procuraId);

            if (empresa != null)
            {
                Console.WriteLine("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                empresa.AumentoDeSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse Id nao existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Update realizado: ");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }



}

