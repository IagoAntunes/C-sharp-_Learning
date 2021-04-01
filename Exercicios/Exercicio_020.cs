using System; 

class URI {

    static void Main(string[] args) { 

        double x1,y1,x2,y2,distancia;
        
        string[] num = new string[2];
        string[] num2 = new string[2];
        num= Console.ReadLine().Split(' ');
        num2= Console.ReadLine().Split(' ');
        
        x1 = double.Parse(num[0]);
        y1 = double.Parse(num[1]);
        
        x2 = double.Parse(num2[0]);
        y2 = double.Parse(num2[1]);



        distancia = Math.Sqrt((Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)));
        
        Console.WriteLine("{0:f4}",distancia);

    }

}