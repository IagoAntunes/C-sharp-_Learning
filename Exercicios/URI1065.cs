using System; 

class URI {

    static void Main() { 

        int num,par=0;

        for(int i=0;i<5;i++){
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0){
                par++;
            }
        }
        Console.WriteLine("{0} valores pares",par);
    }
}