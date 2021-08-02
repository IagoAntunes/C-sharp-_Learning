using System; 

class URI {

    static void Main(string[] args) { 

        int num;

        num = int.Parse(Console.ReadLine());


        for(int i=1;i<=10;i++){
            Console.WriteLine("{0} x {1} = {2}",i,num,i*num);
        }
    }
}