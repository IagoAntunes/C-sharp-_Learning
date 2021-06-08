using System; 

class URI {
    // URI 1155
    static void Main() { 
        
        int N;
        int j=0,soma=0;

        N = int.Parse(Console.ReadLine());
        while(N!=0){
            string[] vetor = Console.ReadLine().Split(' ');
        
            int X = int.Parse(vetor[0]);
            int Y = int.Parse(vetor[1]);
            j = 0;
            soma = 0;
            for(int i = X;j<Y;i++){
                if(i % 2 != 0){
                    soma = soma + i;
                    j++;
                }
            }
            N--;
            Console.WriteLine("{0}",soma);
        }
    }
}
