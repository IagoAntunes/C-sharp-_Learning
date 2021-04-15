using System; 

class URI {

    static void Main(string[] args) { 

        int x,count=0;
        x = int.Parse(Console.ReadLine());

        while(count != 6){
            if(x % 2 != 0){
                Console.WriteLine("{0}", x);
                count ++;
            }
            x++;
        }
    }
}