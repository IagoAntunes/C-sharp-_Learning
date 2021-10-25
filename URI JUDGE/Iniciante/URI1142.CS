using System; 

class URI {

    static void Main(string[] args) { 
        
        int N,i=1,j=2,k=3;

        N = Int32.Parse(Console.ReadLine());
    
        while(N !=0){
            Console.WriteLine("{0} {1} {2} PUM",i,j,k);
            i+=4;j+=4;k+=4;
            N--;
        }  
    }
}