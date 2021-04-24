using System; 

class URI {

    static void Main(string[] args) { 

        int num;

        num = int.Parse(Console.ReadLine());


        for(int i=0;i<10000;i++){
            if(i % num == 2){
                Console.WriteLine("{0}",i);
            }
        }
    }
}