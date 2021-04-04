using System; 

class URI {

    static void Main(string[] args) { 

        int A,B,C,D;
        
        string[] vetor = Console.ReadLine().Split(' ');
        
        A = int.Parse(vetor[0]);
        B = int.Parse(vetor[1]);
        C = int.Parse(vetor[2]);
        D = int.Parse(vetor[3]);
        
        
        if(B > C & D > A & (C+D)>(A+B) & C>0 & D>0 & A % 2 ==0){
            Console.WriteLine("Valores aceitos");
        }else{
            Console.WriteLine("Valores nao aceitos");
        }
    }
}
