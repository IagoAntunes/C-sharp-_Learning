using System; 

class URI {
    // URI 1071

    static void maiorX(int X,int Y,ref int soma){
        for(int i = Y+1;i<X;i++){
            if(i % 2 != 0 ){
                soma = soma + i;
            }
        }


    }
    static void maiorY(int X,int Y,ref int soma){
        for(int i = X-1;i<Y;i++){
            if(i % 2 != 0 ){
                soma = soma + i;
            }
        }
    }
    
    static void Main() { 
        
        int X,Y;
        int soma=0;

        X = int.Parse(Console.ReadLine());
        Y = int.Parse(Console.ReadLine());

        if(X > Y){
            maiorX(X,Y,ref soma);
        }else if(Y > X){
            maiorY(X,Y,ref soma);
        }else{
            soma = 0;
        }

        Console.WriteLine("{0}",soma);

    }
}
