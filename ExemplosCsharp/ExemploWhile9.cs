using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile9
    {
        public static void Main(String[] args)
        {
            int soma = 0;
            int contador = 1;

            while (contador <= 100)
            {
                soma = soma + contador;
                contador++;
            }
            Console.WriteLine(soma);
        }
    }
}

