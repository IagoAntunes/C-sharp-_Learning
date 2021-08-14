using System;

namespace Criandu
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica,0,0,"Eliezaer zarpelao");



            Console.WriteLine(minhaConta.ToString());
        }


    
    }
}
