using System;

namespace _13Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            pessoaFisica pf = new pessoaFisica();
            pf.taxaEmprestimo(1000);

            pessoaJuridica pj = new pessoaJuridica();
            pj.taxaEmprestimo(1000);

            


        }
    }
}
