using System; 

class URI {

    //1159
    static void Main() { 

       int X,soma;

       while(X != 0){
           X = int.Parse(Console.ReadLine());
           for(int i = X;j<5;i++){
               if(i % 2 == 0){
                   j++;
                   soma = soma + i;
               }
           }
            Console.WriteLine("{0}",soma);

       }
        
    }
}