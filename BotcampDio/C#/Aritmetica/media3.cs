using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0]);
            b = double.Parse(values[1]);
            c = double.Parse(values[2]);
            d = double.Parse(values[3]);
            avg = ((a*2)+(b*3)+(c*4)+(d*1))/(2+3+4+1);
            Console.WriteLine("Media: " +avg.ToString("0.0"));
            if (avg >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            if (avg < 5.0       )
            {
                Console.WriteLine("Aluno reprovado.");
            }
            if (avg > 5.0 && avg < 6.9)
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:f1}",e);
                avg = ( e + avg            ) / 2;
                if ( avg >= 5.0                   )
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                if ( avg <= 4.9                 )
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine("Media final: {0:f1}",avg);
            }

            Console.ReadKey();
        }
    }
}