using System;
using System.Linq;

class simpleCalculate{

    static void Main(string[] args){

        var prod1 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToArray();
        var prod2 = Console.ReadLine().Split(' ').Select(s => float.Parse(s)).ToArray();

        float total = 0.0f;
        total = (prod1[1] * prod1[2]) + (prod2[1] * prod2[2]);

        Console.WriteLine("VALOR A PAGAR: R$ {0:F2}", total);

    }
}