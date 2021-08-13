/*Você está na feira com a sua sacola e parou em uma banca.
 O feirante lhe entregou pimentões amarelos e vermelhos. 
Agora iremos somar os pimetões amarelos e vermelhos para descobrir o total de pimentões na sacola. 
Você receberá 2 inteiros que devem ser lidos e armazenados
nas variáveis A (pimentões amarelos) e B (pimentões vermelhos). 
Faça a soma de A e B atribuindo o seu resultado na variável X (total de pimentões). 
Apresente X como descrito na mensagem de exemplo abaixo. 
Não apresente outra mensagem além da mensagem especificada.
*/

using System;

namespace VisitaNaFeira
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry = Console.ReadLine();
            var numbers = entry.Split(" ");
            //Pimentao amarelo
            int a = int.Parse(numbers[0]);
            //Pimentao vermelho
            int b = int.Parse(numbers[1]);   
            //Total
            int x = a + b;

            Console.WriteLine($"X = {x}");
        }
    }
}

