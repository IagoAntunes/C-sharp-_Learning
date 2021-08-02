using System; 

class URI {

    static void Main(string[] args) { 


        float A,B,C,MEDIA;
        
        A = float.Parse(Console.ReadLine());
        B = float.Parse(Console.ReadLine());
        C = float.Parse(Console.ReadLine());
        
        MEDIA = ((A*2 + B*3 + C*5))/10;
        
        Console.WriteLine("MEDIA = {0:f1}",MEDIA);


    }
}