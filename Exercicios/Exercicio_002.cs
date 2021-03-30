/*Faça um programa para receber 10 números inteiros em um vetor A e 10 números em um vetor B. Grave os dados digitados em um vetor C de 20 posições. Sendo as 10 primeiras posições valores do vetor a e os 10 últimos valores do vetor B. Ao final liste os dados do vetor C.*/

using System; 

class minhaClasse{

    static void Main() { 

        int[] vetor1=new int[10] {1,2,3,4,5,6,7,8,9,10};
        int[] vetor2=new int[10] {11,12,13,14,15,16,17,18,19,20};
        int[] vetor3=new int[20];
        int i;

        for(i=0;i<10;i++){
                vetor3[i] =  vetor1[i];
        }
        for(i=10;i<20;i++){
                vetor3[i] = vetor2[i-10];
        }
        
        for(i=0;i<20;i++){
            Console.WriteLine("{0}  ",vetor3[i]);
        }
    }
}