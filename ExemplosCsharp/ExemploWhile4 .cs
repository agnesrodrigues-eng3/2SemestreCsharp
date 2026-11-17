using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile4
    {
        public static void Main(string[] args)
        {//Este exemplo utilizamos o if para fazer a validação de qual número mostrar.
         //Mostrando apenas o resultado restante que é considerado ímpar. 
            int numero = 1;

            while(numero <= 25)
            {
                if (numero % 2 == 1) 
                {
                    Console.WriteLine(numero);
            
                }
                numero++;
            }
        }
    }
}
