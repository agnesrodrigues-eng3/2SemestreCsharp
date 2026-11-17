using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploForeach1
    {
        public static void Main(String[] args)
        {
            String[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            foreach (String i in cars)
            {
                Console.WriteLine(i);
            }
        }

    }
}
