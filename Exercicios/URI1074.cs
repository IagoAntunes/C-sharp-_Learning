using System; 

class URI {

    static void Main(string[] args) { 
   
        int num;
        int[] vetor = new int[5];

        num = int.Parse(Console.ReadLine());

        for(int i=0;i<num;i++){
            vetor[i] = int.Parse(Console.ReadLine());
        }

        for(int j=0;j<num;j++){
            if(vetor[j] == 0){
                Console.WriteLine("NULL");
            }
            if(vetor[j] % 2 == 0 ){
                if(vetor[j] > 0){
                    Console.WriteLine("EVEN POSITIVE");
                }else if(vetor[j] < 0){
                    Console.WriteLine("EVEN NEGATIVE");
                }
            }else if(vetor[j] % 2 != 0){
                if(vetor[j] > 0){
                    Console.WriteLine("ODD POSITIVE");
                }else if(vetor[j] < 0){
                    Console.WriteLine("ODD NEGATIVE");
                }
            }
        } 
    }
}
