using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExemplosCsharp
{
    internal class ExemploWhile7
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Digite um um número positivo");

           int  numero = Convert.ToInt16(Console.ReadLine());

            while (numero < 0)
            {
                Console.WriteLine("Digite um um número positivo");

                numero = Convert.ToInt16(Console.ReadLine());
            }
        }
    }
}

