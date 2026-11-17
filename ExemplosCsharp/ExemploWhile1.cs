using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile1
    {
        public static void Main(String[] args)
        {
            int contadora = 0;

            while (contadora < 11)
            {
                Console.WriteLine(contadora);
                contadora++;
            }
        }
    }
}
