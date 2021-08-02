using System; 

class URI {
    // URI 1072
    
    static void Main() { 
        
        int N, num;
        int dentro=0 , fora=0;

        N = int.Parse(Console.ReadLine());

        for(int i =0;i<N;i++){
            num = int.Parse(Console.ReadLine());
            if(num >= 10 && num <= 20){
                dentro ++;
            }else{
                fora++;
            }
        }

        Console.WriteLine("{0} in",dentro);
        Console.WriteLine("{0} out",fora);
    }
}
