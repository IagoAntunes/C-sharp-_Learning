using System;

namespace apagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja();

            Console.WriteLine("Nome do produto:");
            String nomeP = Console.ReadLine();

            Console.WriteLine("Codigo do produto:");
            int codP = Int32.Parse(Console.ReadLine());

            loja.adicionaProduto(new Produto(nomeP,codP));


            foreach(Produto x in loja.getprodutos){
                Console.WriteLine(x.ToString());
            }   


        }
    }
}
