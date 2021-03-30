/*Elaborar um programa para ler a nota de 5 alunos de uma disciplina e armazenar em um vetor. Calcular e imprimir a
média e o número de alunos que tiveram nota superior à média. Em todas as etapas do problema utilizar uma estrutura
em laço para facilitar as tarefas.*/

using System; 

class minhaClasse{

    static void Main() { 

        int[] vetor=new int[5];
        int soma,media,maiorM;

        for(int i=0;i<5;i++){
            vetor[i] = int.Parse(Console.ReadLine());
            soma = soma + vetor[i];
        }
        media = soma / 5;
        for(int i=0;i<5;i++){
            if(vetor[i] > media ){
                maiorM ++;
            }
        }
        
        Console.WriteLine("MEDIA = {0} \n Numero de pessoas acima da media {1}",media,maiorM);

    }
}