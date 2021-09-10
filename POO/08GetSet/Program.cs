using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "ranfal";
            Console.WriteLine("{0}",pessoa.Nome);

        }
    }
}
