using System; 

class URI {
    // URI 1178
    static void Main() { 
        
        double X = double.Parse(Console.ReadLine());
        double[] N = new double[100];

        N[0] = X;
        for(int i = 1;i<N.Length;i++){
            N[i] = N[i-1]/2;
        }
        for(int i = 0;i<N.Length;i++){
            Console.WriteLine("N[{0}] = {1:f4}",i,N[i]);
        }
    }
}
