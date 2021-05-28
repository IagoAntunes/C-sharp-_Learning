using System; 

class URI {

    static void Main(string[] args) { 

       int X,Y;
       int maior=0,menor=0;

        X = int.Parse(Console.ReadLine());
        Y = int.Parse(Console.ReadLine());

       if(X > Y){
           maior = X;
           menor = Y;
       }else if(X < Y){
           maior = Y;
           menor = X;
       }
        for(int i=menor;i<maior;i++){
            if(i % 5 == 2 || i % 5 == 3 ){
                if(i!= maior && i!= menor){
                    Console.WriteLine("{0}",i);
                }
            }
        }
        
    }
}
