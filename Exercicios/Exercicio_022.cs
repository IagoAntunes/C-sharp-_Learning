using System; 

class URI {

    static void Main(string[] args) { 

    int X;
    double Y,total;
    
    X = int.Parse(Console.ReadLine());
    Y = double.Parse(Console.ReadLine());
    
    total = X/Y;
    
    Console.WriteLine("{0:f3} km/l",total);
    

    }

}