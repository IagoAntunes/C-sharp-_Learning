/* 
            -------------EXERCICIO001-------------
        Elabore um algoritmo que calcule a idade média de 5 alunos 
*/

using System;       

class Aula21 {

    static void Main(){

        int[] alunos=new int[5];

        int media=0;

        for(int i=0;i<alunos.Length;i++){
            Console.WriteLine("Aluno{0}",i);
            alunos[i] = int.Parse(Console.ReadLine());
            media = media + alunos[i];
        }
        
        Console.WriteLine("Media = {0}",media/5);

    }

}