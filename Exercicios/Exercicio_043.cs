using System; 

class URI {

    static void Main(string[] args) { 

            
        string[] vetor = {"January","February","March","April","May","June","July","August","September","October","November","December"};
   
        int num;

        num = int.Parse(Console.ReadLine());

        Console.WriteLine(vetor[num-1]);

    }
}