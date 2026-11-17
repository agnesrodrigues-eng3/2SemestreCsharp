using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile6
    {
        public static void Main(String[] args)
        {
            int numero = 50;

            while(numero >=0)
            {
                Console.WriteLine(numero);
                numero -= 5;
            }
        }
    }
}
//Tipo de contagem	Condição
// Crescente:   até 50	numero <= 50
//Decrescente:  até 0	numero >= 0


