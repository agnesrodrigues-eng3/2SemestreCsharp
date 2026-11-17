using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile3
    {
        public static void Main(String[] args)
        {
            int contadora = 20;

            while (contadora >=1)
            {
                Console.WriteLine(contadora);
                contadora--;

            }
        }
    }
}
//Quando é em ordem descrente utilizamos o -- que é o desencremento, ex: 5<-6<-7, a cada rodada vai diminuindo mais 1.
//Quando aumentamos utilizamos o incremento, que é ++, ex:7<-6<-5, a cada rodada vai somando mais 1.