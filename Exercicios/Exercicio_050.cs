using System; 

class URI {

    static void Main(string[] args) { 

        int qtd;
        double X,Y,div;

        qtd = int.Parse(Console.ReadLine());

        for(int i=0;i<qtd;i++){

            string[] vetor = Console.ReadLine().Split(' ');
        
            double X = int.Parse(vetor[0]);
            double Y = int.Parse(vetor[1]);
            if(Y == 0){
                Console.WriteLine("divisao impossivel");
            }else{
                double div = (double)X/Y;
                Console.WriteLine("{0}",div);
            }
        }
    }
}