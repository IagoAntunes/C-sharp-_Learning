using System; 

class URI {

    static void Main(string[] args) { 

        int A,B;

        string[] vetor = Console.ReadLine().Split(' ');
        
        A = int.Parse(vetor[0]);
        B = int.Parse(vetor[1]);


        if(A % B == 0 || B % A == 0){
            Console.WriteLine("Sao Multiplos");
        }else {
             Console.WriteLine("Nao sao Multiplos");
        }
    }
}