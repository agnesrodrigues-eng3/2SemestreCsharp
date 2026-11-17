using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCsharp
{
    internal class ExemploWhile10
    {
        public static void Main(string[] args)
        {
            // Criamos uma variável chamada "numero".
            // Ela começa com 0 porque precisamos inicializá-la
            // antes de utilizá-la na condição do while.
            // Esse 0 é apenas um valor inicial, não é um número
            // digitado pelo usuário.
            int numero = 0;
            int soma = 0;


            //Antes de iniciarmos o while, precisamos solicitar o primeiro número ao usuário
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());


            //Valida se este número digitado é diferente de 0; sendo diferente, entra no laço de repetição
            //O símbolo != significa "diferente de".
            // Portanto, numero != 0 significa:
            // "O número informado é diferente de zero?"
            //
            // Se for verdadeiro (true), entra no while.
            // Se for falso (false), encerra a repetição.
            while (numero != 0)
            {
                // SOMA:
                // Adicionamos o número digitado ao valor
                // que já está armazenado na variável "soma".
                //
                // Exemplo:
                // soma = 0 e numero = 5
                // soma = 0 + 5
                // Agora soma vale 5.
                soma = soma + numero;

                // PRÓXIMA LEITURA:
                // Solicitamos outro número ao usuário.
                // Essa leitura precisa ficar dentro do while
                // para que a variável "numero" seja atualizada
                // a cada repetição.
                //
                // Assim, o programa consegue verificar se
                // o usuário digitou 0 para encerrar o laço.
                Console.WriteLine("Digite um número");
                numero = Convert.ToInt32(Console.ReadLine());

                



            }
            // RESULTADO FINAL:
            // Quando o usuário digitar 0, a condição do while
            // será falsa e o programa chegará até esta linha.
            // Exibimos a soma de todos os números informados.
            Console.WriteLine("A soma dos números digitados é : " + soma);
        }
    }
}