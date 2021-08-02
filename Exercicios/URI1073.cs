using System; 

class URI {

    static void Main(string[] args) { 
   
        int num;
        
        num = int.Parse(Console.ReadLine());

        for(int i =2;i<=num;i++){
            if(i % 2 ==0){
                Console.WriteLine("{0}^2 = {1}",i,Math.Pow(i,2));
            }
        }
    }
}
