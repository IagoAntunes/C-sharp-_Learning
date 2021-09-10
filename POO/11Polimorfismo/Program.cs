using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto estagiario = new Estagiario();
            Imposto gerente = new Gerente();
            Imposto atendente = new Atendente();

            estagiario.valeAlimentacao(1000);
            estagiario.valeTransporte(1000);
            Console.WriteLine("------");

            gerente.valeAlimentacao(5000);
            gerente.valeTransporte(5000);
            Console.WriteLine("------");

            atendente.valeAlimentacao(2000);
            atendente.valeTransporte(2000);
            Console.WriteLine("------");






        }
    }
}
