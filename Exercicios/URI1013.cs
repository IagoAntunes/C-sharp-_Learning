using System; 

class URI {

    static void Main(string[] args) { 

        int A,B,C,maior=0,maior1;
        
        string[] vetor = Console.ReadLine().Split(' ');
    
        A = int.Parse(vetor[0]);
        B = int.Parse(vetor[1]);
        C = int.Parse(vetor[2]);

        maior1 = (A + B + Math.Abs(A - B)) / 2;
        maior = (maior1 + C + Math.Abs( maior1 - C ))/2;

        Console.WriteLine("{0} eh o maior",maior);
        
    }
}