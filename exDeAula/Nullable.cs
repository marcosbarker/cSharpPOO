using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double x = null; "Não é possível converter nulo para 'double' porque ele é um tipo de valor não-nulo:"
             
            Metodos:

            GetValueOrDefault (pega o valor da variavel, caso seja nulo, pega o valor default do tipo. Ex: double é 0)
            HasValue (retorno booleano se tem ou nao valor)
            Value (lanca execao se nao houver valor)         
             
             */


            Nullable<double> x = null; 

            double? y = null; /*Versao syntax sugar*/

            double? z = 10.0;

            double a = y ?? 20; /* ?? operador de coalescencia nula (pega o valor da variavel caso tenha, senao, pega o valor a direita)*/
            double b = z ?? 20;

            Console.WriteLine("GetValueOrDefault sem valor " + y.GetValueOrDefault());
            Console.WriteLine("GetValueOrDefault com valor " + z.GetValueOrDefault());

            Console.WriteLine("HasValue sem valor " + y.HasValue);
            Console.WriteLine("HasValue com valor " + z.HasValue);

            Console.WriteLine("Operador coalescencia nula " + a);
            Console.WriteLine("Operador coalescencia nula " + b);

            /* 
             Console.WriteLine("Value com valor " + y.Value);
             Console.WriteLine("Value com valor " + z.Value);
            */

            /*Forma de usar o Value*/

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y é Nulo");           
            if(z.HasValue)
                Console.WriteLine(z.Value);
            else
                Console.WriteLine("Z é nulo");
        }
    }
}