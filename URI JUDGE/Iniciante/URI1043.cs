using System; 

class URI {

    static void Main(string[] args) { 

        double A,B,C,per,area;

        string[] vetor = Console.ReadLine().Split(' ');
        
        A = double.Parse(vetor[0]);
        B = double.Parse(vetor[1]);
        C = double.Parse(vetor[2]);
        
        
        if(A + B > C && A + C > B && B + C > A){
            per = A + B + C;
            Console.WriteLine("Perimetro = {0:f1}",per);
        }else{
            area = ((A+B)*C)/2;
            Console.WriteLine("Area = {0:f1}",area);
        }



    }
}