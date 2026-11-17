using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile8
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("---Digite um número e descubra sua tabuada de 1 ao 10---");
            int numero = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            int contadora = 1;

            int multiplicadora = 0;

            while (contadora < 11)
            {
                multiplicadora = numero * contadora;
                Console.WriteLine( $"{numero} x  {contadora}  =  {multiplicadora}");
                contadora++;
            }
            
        }

    }
}

