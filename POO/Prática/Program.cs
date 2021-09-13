using System;

namespace Prática
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabalhador trab = new Trabalhador(1,"Lucas",1100);

            trab.gstotalProdutos = 0;

            Console.WriteLine("Nome:{0}\nSalário:{1}\nMatricula:{2}",trab.Nome,trab.Salario,trab.Matricula);
            trab.aumento();
            Console.WriteLine("Nome:{0}\nSalário:{1}\nMatricula:{2}",trab.Nome,trab.Salario,trab.Matricula);
        }
    }
}
