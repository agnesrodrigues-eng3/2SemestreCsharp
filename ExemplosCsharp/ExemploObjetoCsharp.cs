using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ExemplosCsharp
{

    internal class Carro
    {

        string color = "red";

        public static void Main(string[] args)
        {
            Carro carroJailson = new Carro();
            Console.WriteLine("A cor do carro do funcionário Jailson é : " + carroJailson.color);
        }
    }
}  

