using System; 

class URI {

    static void Main(string[] args) { 

       int X,Y;
       int maior=0,menor=0,soma=0;

        X = int.Parse(Console.ReadLine());
        Y = int.Parse(Console.ReadLine());

       if(X > Y){
           maior = X;
           menor = Y;
       }else if(X < Y){
           maior = Y;
           menor = X;
       }
        for(int i=maior;i>=menor;i--){
            if(i % 13 != 0){
                soma = soma + i;
            }
        }
        Console.WriteLine("{0}",soma);
    }
}
