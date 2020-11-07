/* 
            -------------EXERCICIO004-------------
         Faça um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%.
*/

using System;       

class Aula21 {

    static void Main(){
        float[] salarios=new float[10];
        int i;

        for(i=0;i<salarios.Length;i++){
            Console.WriteLine("Salario{0}:",i);
            salarios[i] = float.Parse(Console.ReadLine());
            if(salarios[i] <=300){
                salarios[i] = (salarios[i] / 1/2) + salarios[i];
            }else if (salarios[i] > 300){
                salarios[i] = (30 * salarios[i])/100 + salarios[i];
            }
        }
        Console.Clear();
        Console.WriteLine("Novos Salários:");
        for (i=0;i<salarios.Length;i++){
            Console.WriteLine("Funcionario{0} Salário:{1}",i,salarios[i]);
        }
    }

}