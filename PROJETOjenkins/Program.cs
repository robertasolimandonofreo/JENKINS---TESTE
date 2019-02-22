using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n1, n2, resultado;

                Console.Write("Informe o primeiro número - >");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número - >");
                n2 = int.Parse(Console.ReadLine());

                resultado = n1 + n2;

                Console.Write(resultado);

                Console.ReadKey();
            }
        }
    }



}