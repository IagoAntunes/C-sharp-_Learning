using System; 

class URI {

    static void Main(string[] args) { 

        double A,B,C,R1,R2,delta,raiz;
        
        string[] vetor = Console.ReadLine().Split(' ');
        
        A = double.Parse(vetor[0]);
        B = double.Parse(vetor[1]);
        C = double.Parse(vetor[2]);
        
        delta = (Math.Pow(B,2) - 4 * A * C);
        raiz = Math.Sqrt(delta);

        R1 = (-B + raiz)/(2*A);
        R2 = (-B - raiz)/(2*A);

        if(raiz < 0 | A == 0 | delta < 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            Console.WriteLine("R1 = {0:f5}",R1);
            Console.WriteLine("R2 = {0:f5}",R2);
        }


    }

}