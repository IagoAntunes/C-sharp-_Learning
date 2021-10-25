using System;

namespace C_sharp__Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoa p = new pessoa();
            p.nome = "Pedro";
            p.idade = 17;
            
            Console.WriteLine(p.Mensagem());

        }
    }
}
