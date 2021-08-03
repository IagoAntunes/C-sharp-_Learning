using System; 

class URI {
    // URI 1175

    static void Main() { 
        
        int[] vetor = new int[20];
        int aux1;

        for(int i =0;i<vetor.Length;i++){
            vetor[i] = int.Parse(Console.ReadLine());
        }
        for(int j = 0;j<10;j++){
            aux1 = vetor[j];
            vetor[j] = vetor[19 - j];
            vetor[19 - j] = aux1;
        }
        for(int i =0;i<vetor.Length;i++){
            Console.WriteLine("N[{0}] = {1}",i,vetor[i]);
        }
    }
}
