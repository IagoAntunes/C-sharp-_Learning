using System;
class URI {
    // URI 1180

    static int menor(int[] vetor,ref int menorN,int N){
        int indice=0;
        for(int i =0;i<N;i++){
            if(vetor[i] < menorN){
                menorN = vetor[i];
                indice = i;
            }
        }
        return indice;
    }
    static void printar(int menorN,int indice){
        Console.WriteLine("Menor Valor: {0}",menorN);
        Console.WriteLine("Posicao: {0}",indice);
    }

    static void Main() { 
        
        int N,menorN,indice;
        N = int.Parse(Console.ReadLine());
                    
        string[] vetor = Console.ReadLine().Split(' ');
        int[] num = new int[N];

        for(int i = 0;i<N;i++){
            num[i] = int.Parse(vetor[i]);
        }
        menorN = num[0];

        indice = menor(num,ref menorN,N);
        printar(menorN,indice);
    }
}
