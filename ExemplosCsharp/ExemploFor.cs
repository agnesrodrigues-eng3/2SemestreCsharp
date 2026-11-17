using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploFor
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Laço de repetição for");

            for (int contadora = 0; contadora < 11; contadora++)
            {//tipo da contadora/ quantas vezes irá repetir/quantas vezes ela vai incrementar
                Console.WriteLine(contadora);
            }//exibir
        }
    }
}
