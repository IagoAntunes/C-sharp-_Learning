using System; 

class URI {

    static void Main(string[] args) { 

        int food,qtd;
        double total;

        string[] vetor = Console.ReadLine().Split(' ');
        double[] array1 = new double[5] {4.00,4.50,5.00,2.00,1.50};
        
        food = int.Parse(vetor[0]);
        qtd = int.Parse(vetor[1]);

        total = array1[food - 1] * qtd;

        Console.WriteLine("Total: R$: {0:f2}",total);






    }
}