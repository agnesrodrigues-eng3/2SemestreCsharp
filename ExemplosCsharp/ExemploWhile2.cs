using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile2
    {
        public static void Main(String[] args)
        {
            int contadora = 1;

            while (contadora < 11)
            {
                Console.WriteLine(contadora);
                contadora++;
            }
        }
    }
}
