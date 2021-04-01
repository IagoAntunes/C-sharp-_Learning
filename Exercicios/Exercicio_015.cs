using System; 

class URI {

    static void Main(string[] args) { 

        double R,pi=3.14159,VOLUME;
        
        R = double.Parse(Console.ReadLine());
        VOLUME = ((4/3.0)*pi)* Math.Pow(R,3);
    
        Console.WriteLine("VOLUME = {0:f3}",VOLUME);
    }

}