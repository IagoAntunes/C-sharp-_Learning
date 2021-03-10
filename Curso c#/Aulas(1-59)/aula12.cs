using System;
//IF
class Aula12 {

    static void Main(){

        int n1,n2,n3,n4,res;
        string resultado="Reprovado";

        Console.WriteLine("Digite a Nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;

        if(res >= 60){
            //Console.WriteLine("Você esta APROVADO");
            resultado = "Aprovado";
        }

        Console.WriteLine("Nota: {0}\nResultado:{1}",res,resultado);

    }
}