using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class Moto
    {
        string color = "azul";

        float preco = 500.000f;

        float modelo = 2019f;

        string marca = "BMW";

        string localCompra = "Centro de São-Paulo";




        public static void Main(string[] args)
        {
            Moto motoCaio = new Moto();
            Console.WriteLine("A cor da moto do aluno Caio é : " +motoCaio.color);
            Console.WriteLine("O preço de sua moto é :" +motoCaio.preco);
            Console.WriteLine("O modelo desta moto é : " +motoCaio.modelo);
            Console.WriteLine("A marca de sua moto é :" +motoCaio.marca);
        }
    }
}
