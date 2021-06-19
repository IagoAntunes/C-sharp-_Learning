using System; 

class URI {
    // URI 1173
    static void Main() { 
        int j;
        int aux,aux2;
        int[] X = new int [10];

        for(int i = 0 ;i<10;i++){
            X[i]= int.Parse(Console.ReadLine());
        }
        j = 10;
        for(int i =0;i!=5;i++){
            aux = X[i]; // = 1
            aux2 = X[j];// 10
            X[i] = aux2;
            X[j] = aux;
            j--;
        }
        for(int i =0;i<10;i++){
            Console.WriteLine("{0}",X[i]);
        }
    }
}
