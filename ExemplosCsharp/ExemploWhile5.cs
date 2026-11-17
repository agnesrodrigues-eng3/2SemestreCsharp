using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile5
    {
        public static void Main(string[] args)
        {//Neste caso utilizamos o número+=2, porque ele irá acrescentar números de 2 em 2, e como a contadora já se inicia com 1,
         //ela estará sempre cresecendo em números ímpares.
            int numero = 1;

            while(numero <= 25)
            {
                while (numero <= 25)
                {
                    Console.WriteLine(numero);
                    numero += 2;
                }
            }
        }
    }

}

//Código	      Significado
//numero++        Soma 1
//numero += 2     Soma 2
//numero += 3     Soma 3
//numero--        Diminui 1
//numero -= 2     Diminue 2