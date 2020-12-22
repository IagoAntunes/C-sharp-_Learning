using System;

class Aula06{

    static void Main(){
        
        double valorCompra=5.50;
        double valorVenda;
        double lucro=0.1;
        string produto="Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto.......{0,15}",produto);
        Console.WriteLine("Val.Compra....{0,15:c}",valorCompra);
        Console.WriteLine("Lucro.........{0,15:p}",lucro);
        Console.WriteLine("Val.Venda.....{0,15:c}",valorVenda);
    
        /* 
        int n1=10,n2=20,n3=30;
        \n  \t
        Console.Write("n1 = {0},n2={1},n3={2}",n1,n2,n3 );
        */
    }
}