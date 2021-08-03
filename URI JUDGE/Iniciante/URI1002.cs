using System; 

class URI {

    static void Main(string[] args) { 

        double area,n = 3.14159,raio;
        
        raio = Double.Parse(Console.ReadLine());
        area = n * Math.Pow(raio,2);
        
        Console.WriteLine("A= {0:f3}",area);
        
    }

}
