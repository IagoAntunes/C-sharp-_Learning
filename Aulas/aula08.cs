using System;

class Aula08 {
    static void Main(){
        int v1,v2,soma;
        string nome;

        Console.WriteLine("Qual o seu Nome ?");
        nome =Console.ReadLine();

        Console.Write("Digite o primeiro valor: ");
        v1 =int.Parse(Console.ReadLine());
        Console.Write("Digite o Segundo Valor: ");
        v2 =Convert.ToInt32(Console.ReadLine());

        soma = v1 + v2;


        Console.WriteLine("Ola {3}, os resultados dos valores digitados são:\n{0} + {1} = {2} ",v1,v2,soma,nome);


        /*
            Console.Write("Digite Seu Nome:");
            nome = Console.ReadLine();
            
            Console.WriteLine("Ola {0} prazer em te conhecer",nome);
        */ 
    }
}