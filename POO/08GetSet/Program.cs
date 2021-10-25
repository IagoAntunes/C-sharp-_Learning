using System;

namespace _08GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.Nome = "ranfal";
            pessoa.idade = 5;
        
            Console.WriteLine("{0} e nota = {1}",pessoa.Nome,pessoa.idade);
            
    



        }
    }
}
