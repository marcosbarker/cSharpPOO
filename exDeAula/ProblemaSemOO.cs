using System;

class ProblemaSemOO
{
    static void Main(string[] args)
    {
        double xA, xB, xC, yA, yB, yC;

        Console.WriteLine("Entre com as medidas do triangulo X: ");
        xA = double.Parse(Console.ReadLine());
        xB = double.Parse(Console.ReadLine());
        xC = double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triangulo Y: ");
        yA = double.Parse(Console.ReadLine());
        yB = double.Parse(Console.ReadLine());
        yC = double.Parse(Console.ReadLine());

        double p = (xA + xB + xC) / 2.0;
        double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine("Área de x = " + areaX.ToString("F4"));
        Console.WriteLine("Área de y = " + areaY.ToString("F4"));


        if (areaX > areaY)
        {
            Console.WriteLine("Maior area: X");
        }
        else if (areaX == areaY)
        {
            Console.WriteLine("As areas são iguais");
        }
        else
        {
            Console.WriteLine("Maior area: Y");

        }
    }
}