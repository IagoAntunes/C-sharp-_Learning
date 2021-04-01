using System; 

class URI {

    static void Main(string[] args) { 

        double A,B,C,areaT,areaC,areaTr,areaQ,areaR;
        
        string[] num= Console.ReadLine().Split(' ');
        A = double.Parse(num[0]);
        B = double.Parse(num[1]);
        C = double.Parse(num[2]);

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