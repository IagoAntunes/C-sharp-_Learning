using System; 

class URI {

    static void Main(string[] args) { 

        string nome;
        double salario,venda,total;
        
        nome = Console.ReadLine();
        salario = float.Parse(Console.ReadLine());
        venda = float.Parse(Console.ReadLine());
        
        total = (salario + (venda * 0.15));
        
        Console.WriteLine("TOTAL = R$ {0:f2}",total);
        
        

    }

}