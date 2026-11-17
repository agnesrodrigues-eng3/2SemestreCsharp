using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploForeach3
    {
        public static void Main(String[] args)
        {
            int[] idade = { 19, 18, 23, 41 };
            foreach (int contadora in idade)
            {
                Console.WriteLine(contadora);
            }

        }
    }
}
