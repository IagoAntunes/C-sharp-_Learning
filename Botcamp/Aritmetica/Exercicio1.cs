using System; 

class URI {

    static void Main(string[] args) { 

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            //complete com as variaveis
            mediaP = (( a * 3.5) + (  b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000"));

    }

}