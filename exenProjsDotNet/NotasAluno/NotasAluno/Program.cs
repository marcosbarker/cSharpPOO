using System;
using System.Globalization;

namespace NotasAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.NomeAluno = Console.ReadLine();

            Console.WriteLine("Digite tres notas do aluno: ");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);
        }
    }
}
