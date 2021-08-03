using System; 
using System.Globalization;
class URI {

    static void Main(string[] args) { 

        double A,B,C,areaT,areaC,areaTr,areaQ,areaR;

        string[] num = new string[5];


        num= Console.ReadLine().Split(' ');


        A = double.Parse(num[0],CultureInfo.InvariantCulture);
        B = double.Parse(num[1],CultureInfo.InvariantCulture);
        C = double.Parse(num[2],CultureInfo.InvariantCulture);

        areaT = (A*C)/2;
        areaC = 3.14159 * Math.Pow(C,2);
        areaTr = ((A + B)/2)*C;
        areaQ = B * 4;
        areaR = A * B;
        
        Console.WriteLine("TRIANGULO: {0}",areaT);
        Console.WriteLine("CIRCULO: {0}",areaC);
        Console.WriteLine("TRAPEZIO: {0}",areaTr);
        Console.WriteLine("QUADRADO: {0}",areaQ);
        Console.WriteLine("RETANGULO: {0}",areaT);
        
    }
}
/*
using System; 
using System.Linq;
class URI {

    static void Main(string[] args) { 

        double A,B,C,areaT,areaC,areaTr,areaQ,areaR;
        
        var num = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();

        areaT = (num[0]*num[2])/2;
        areaC = 3.14159 * Math.Pow(num[2],2);
        areaTr = ((num[0] + num[1])/2)*num[2];
        areaQ = num[1] * 4;
        areaR = num[0] * num[1];
        
        Console.WriteLine("TRIANGULO: {0}",areaT);
        Console.WriteLine("CIRCULO: {0}",areaC);
        Console.WriteLine("TRAPEZIO: {0}",areaTr);
        Console.WriteLine("QUADRADO: {0}",areaQ);
        Console.WriteLine("RETANGULO: {0}",areaT);
        
    }
}
*/