using System; 

class URI {
    // URI 1173
    static void Main() { 
        
        int num;
        int[] X = new int [100];

        num = int.Parse(Console.ReadLine());
        X[0] = num;
        for(int i = 0 ;i<10;i++){
            X[i+1] = X[i] * 2;
            Console.WriteLine("n[{0}] = {1}",i,X[i]);
        }
    }
}
