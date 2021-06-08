using System; 

class URI {

    //1159
    static void Main() { 

        int X=1,soma;
        int j;
        X = int.Parse(Console.ReadLine());
        while(X != 0){
    
            j =0;
            soma = 0;
            for(int i = X;j<5;i++){
                if(i % 2 == 0){
                   j++;
                   soma = soma + i;
               }
            }
            Console.WriteLine("{0}",soma);
            X = int.Parse(Console.ReadLine());
       } 
    }
}