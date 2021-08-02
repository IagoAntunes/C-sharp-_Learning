using System; 

class URI {

    static void Main(string[] args) { 

        int maior=0,indice=1;
        int[] vetor = new int[105];

        for(int i=1;i<=100;i++){
            vetor[i] = int.Parse(Console.ReadLine());
            if(vetor[i] > maior){
                maior = vetor[i];
                indice = i;
            }
        }
        Console.WriteLine("{0}",maior);
        Console.WriteLine("{0}",indice);

    }
}