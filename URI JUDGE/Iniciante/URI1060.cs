using System; 

class URI {

    static void Main(string[] args) { 

        double count=0;
        double[] numeros = new double[6];   

        for(int i=0;i<6;i++){
            numeros[i] = double.Parse(Console.ReadLine());
            if(numeros[i] > 0){
                count++;
            }
        }
        Console.WriteLine("{0} valores positivos",count);
    }
}