using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploDoWhile
    {
        public static void Main(String[] args)
        {
            int contadora = 0;

            Console.WriteLine("--Programa contadora 0 a 11--");
            Console.WriteLine("--Observe--");

            do
            {
                Console.WriteLine(contadora);
                contadora++;

            }//Executa primeiro/ primeira vez ele executa dps ele testa
            while (contadora < 11);
        }//Depois verifica
    }
}
