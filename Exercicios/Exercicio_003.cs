/*Elaborar um programa em C para receber e armazenar 10 números inteiros em um vetor. Identificar e imprimir o maior
e o menor número e as respectivas posições no vetor*/

using System; 

class minhaClasse{

    static void Main() { 

        int[] vetor=new int[10] {1,2,3,4,5,6,7,8,9,10};
        int maior = vetor[0],menor = vetor[0];
        int indice=0,indice2=0,i;

        for(i=0;i<10;i++){
            if(vetor[i] > maior ){
                maior = vetor[i];
                indice = i;
            }
            if(vetor[1] < menor){
                menor = vetor[i];
                indice2 = i;
            }
        }

        Console.WriteLine("Maior Valor: {0} Posicao {1} ",maior,indice);
        Console.WriteLine("Menor Valor: {0} Posicao {1}", menor,indice2);

    }
}