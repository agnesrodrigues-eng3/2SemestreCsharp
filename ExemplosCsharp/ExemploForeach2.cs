using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploForeach2
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Programa idade");

            int [] idade = { 18 , 42 , 21 , 54 };
            foreach (int contadora in idade)
            {
                Console.WriteLine(contadora);
            }
        }

    }
}

