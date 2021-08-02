using System; 

class URI {

    //1150
    static void Main() { 

        int X,Y;
        int soma=0;
        int qtd=0;

        X = int.Parse(Console.ReadLine());
        Y = X-1;
        while(Y <= X){
            Y = int.Parse(Console.ReadLine());
        }
        for(int i = X ;soma <= Y;X++){
            soma = soma + X;
            qtd++;
        }

        Console.WriteLine("{0}",qtd);
    }
}