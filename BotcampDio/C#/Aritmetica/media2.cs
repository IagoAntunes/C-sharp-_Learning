using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            double mediaP;
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());
            C = double.Parse(Console.ReadLine());
            mediaP = (( A * 2) + ( B * 3) + (C * 5)) / (2 + 3 + 5);
            Console.WriteLine("MEDIA = {0:f1}",mediaP);
            Console.ReadKey();
        }
    }
}