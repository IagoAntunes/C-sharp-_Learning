/*Faça um programa para receber 10 números inteiros. Ao final, multiplique todos os valores pelo 3 valor informado no vetor e apresente o resultado.*/

using System; 

class minhaClasse{

    static void Main() { 

        int tam;

        Console.WriteLine("Tamanho do Vetor:");
        tam = int.Parse(Console.ReadLine());


        int[] vet = new int[tam];


        for(int i=0;i<vet.Length;i++){
            Console.WriteLine("{0} Valor: ",i);
            vet[i] = int.Parse(Console.ReadLine());
        }

        
        for(int i=0;i<vet.Length;i++){
            vet[i] = vet[i] * vet[3];
        }

        for(int i=0;i<vet.Length;i++){
            Console.WriteLine("{0} Valor: {1} ",i,vet[i]);
        }


    }

}