using System; 

class URI {
    // URI 1172
    static void Main() { 
        
        int nTestes;
        int num;
        int ctg;

        int[] X = new int [10];

        for(int i =0;i<10;i++){
            X[i] = int.Parse(Console.ReadLine());
             if(X[i] <= 0){
                X[i] = 1;
            }

        }
        for(int i =0;i<10;i++){
            Console.WriteLine("X[{0}] = {1}",i,X[i]);
        }
    }
}
