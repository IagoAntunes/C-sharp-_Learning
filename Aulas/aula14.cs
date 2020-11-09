using System;

class Aula14 {

    static void Main(){

        int n1,n2,n3,n4,res;
        string resultado="";

        Console.WriteLine("Digite a Nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        // >= 60   --> Aprovado
        // 59 e 40 --> Recuperação
        // <40     --> Reprovado

        if(res >= 60){
            if(res >=90){
                if(res >=99){
                    resultado = "Aprovado com SUPER louvor";
                }else{
                    resultado = "Aprovado com Louvor";
                }
            }else{
                resultado = "Aprovado";
            }
        }else{
            if(res >=40){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        }
        Console.WriteLine("Nota: {0}\nResultado:{1}",res,resultado);
    }
}