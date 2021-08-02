using System; 

class URI {
    // URI 1174
    static void Main() { 
        
        double[] X = new double [100];

        for(int i =0;i<100;i++){
            X[i] = double.Parse(Console.ReadLine());
            if(X[i] <= 10){
                Console.WriteLine("A[{0}] = {1:f1}",i,X[i]);
            }
        }
    }
}
