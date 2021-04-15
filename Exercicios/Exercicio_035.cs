using System; 

class URI {

    static void Main(string[] args) { 

        int A,B,horas=0;

        string[] vetor = Console.ReadLine().Split(' ');
        
        A = int.Parse(vetor[0]);
        B = int.Parse(vetor[1]);
   
        if(A > B){
            horas = (24 - A)+B;
        }else if(B > A ){
            horas = (B - A);
        }else if(A == B){
            horas = 24;
        }
        
        Console.WriteLine("O JOGO DUROU {0} HORA(S)",horas);
        
    }
}