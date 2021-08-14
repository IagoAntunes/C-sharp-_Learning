using System;

class Classe {
    static void Main() {
        string[] line = Console.ReadLine().Split();
        double X = double.Parse(line[0]);
        double Y = double.Parse(line[1]);
        Console.WriteLine("{0:f2}",X/Y);
    }
}