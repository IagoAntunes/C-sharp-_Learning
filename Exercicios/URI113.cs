using System; 

class URI {

    static void Main(string[] args) { 

        int x,y;
        int maior,menor;
        int opc = 0;

        while(opc != 1){
            string[] vetor = Console.ReadLine().Split(' ');
            x = int.Parse(vetor[0]);
            y = int.Parse(vetor[1]);
            if(x == y){
                break;
            }
            if(x > y){
                maior = x;
                menor = y;
                Console.WriteLine("Decrescente");
            }else{
                maior = y;
                menor = x;
                Console.WriteLine("Crescente");
            }
        }
    }
}
