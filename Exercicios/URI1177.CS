using System; 

class URI {
    // URI 1177
    static void Main() { 
        
        int t;

        t = int.Parse(Console.ReadLine());

        int[] n = new int[1000];
        int[] vetor = new int[t];

        for(int i =0;i<t;i++){
            vetor[i] = i;
        }
        int i2 =0;
        int j = 0;
        while(i2 < 1000){
            n[i2] = vetor[j];
            i2 = i2 + 1;
            j = j + 1;
            if(j >= t){
                j =0;
            }
        }
        for(int i =0;i<1000;i++){
            Console.WriteLine("N[{0}] = {1}",i,n[i]);
        }


    }
}
