using System; 

class URI {

    static void Main(string[] args) { 

        int x,y;
        int opc = 0;

        while(opc != 1){
            string[] vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);

            if(x > 0 && y > 0){
                Console.WriteLine("primeiro");
            }else if(x > 0 && y < 0){
                Console.WriteLine("quarto");
            }else if(x < 0 && y < 0){
                Console.WriteLine("terceiro");
            }else if(x < 0 && y > 0){
                Console.WriteLine("segundo");
            }else if(x == 0 || y == 0){
                break;
            }
        }
    }
}
