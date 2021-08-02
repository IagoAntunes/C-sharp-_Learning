using System; 

class URI {

    static void Main(string[] args) { 
        
        double maior,menor,aux,meio;

        string[] vetor = Console.ReadLine().Split(' ');
        

        Array.Sort(vetor);
    
        for(int i=0;i<vetor.Length;i++ ){
            Console.WriteLine(vetor[i]);
        }
        
    }
}