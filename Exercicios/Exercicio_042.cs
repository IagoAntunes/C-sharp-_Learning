using System; 

class URI {

    static void Main(string[] args) { 

        double[] vetor = new double[6]; 
        int count=0;
        double media =0;


        for(int i=0;i<6;i++){
            vetor[i] = double.Parse(Console.ReadLine());
            if(vetor[i] > 0){
                media = media + vetor[i];
                count ++;
            }
        }
        Console.WriteLine("{0} valores positivos",count);
        Console.WriteLine("{0:f1}",media/count);
    }
}