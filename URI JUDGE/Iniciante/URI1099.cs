using System; 

class URI {

    static void Main(string[] args) { 

        int N,X,Y;
        int soma=0,maior,menor;

        N = int.Parse(Console.ReadLine());

        while(N != 0){
            string[] vetor = Console.ReadLine().Split(' ');
            X = int.Parse(vetor[0]);
            Y = int.Parse(vetor[1]);
            if(X > Y){
                maior = X;
                menor = Y;
            }else{
                maior = Y;
                menor = X;
            }
            for(int i=maior;i>menor;i--){
                if(i%2 != 0 && i!=maior && i!= menor){
                    soma = soma + i;
                }
            }
            N = N -1;
            Console.WriteLine("{0}",soma);
            soma = 0;
        }
    }
}
