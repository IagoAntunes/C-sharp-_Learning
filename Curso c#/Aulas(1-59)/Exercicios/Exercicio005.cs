/* 
            -------------EXERCICIO005-------------
         Faça um algoritmo que leia a altura e a matricula de dez aluno. Mostre a matricula do aluno mais alto e do aluno mais baixo.
*/

using System;       

class Aula21 {

    static void Main(){
 
        int[] matricula = new int[3];
        int[] altura = new int[3];

        int menor = 900;
        int maior = 0;
        int indiceMa = 0;
        int indiceMe = 0;

        for(int i=0;i<3;i++){
            Console.Write("Aluno{0}",i);
            Console.Write("Matricula:");
            matricula[i] = int.Parse(Console.ReadLine());
            Console.Write("Altura:");
            altura[i] = int.Parse(Console.ReadLine());
            if(altura[i] < menor){
                menor = altura[i];
                indiceMe = i;
            }
            if(altura[i] > maior){
                maior = altura[i];
                indiceMa = i;
            }
        }

        Console.WriteLine("Matricula:{0} Maior Altura:{1}",matricula[indiceMa],maior);
        Console.WriteLine("Matricula:{0} Menor Altura:{1}",matricula[indiceMe],menor);


    }

}