using System; 

class URI {

    static void Main(string[] args) { 

        int M,N;
        int soma=0,maior,menor;
        int opc = 0;

        while(opc != 1){
            string[] vetor = Console.ReadLine().Split(' ');
            M = int.Parse(vetor[0]);
            N = int.Parse(vetor[1]);
            if(M <= 0 || N <= 0){
                break;
            }
            if(M > N){
                maior = M;
                menor = N;
            }else{
                maior = N;
                menor = M;
            }
            for(int i=menor;i<=maior;i++){
                Console.Write("{0} ",i);
                soma = soma + i;

            }
            Console.WriteLine("Sum={0}",soma);
            soma = 0;
        }
    }
}
