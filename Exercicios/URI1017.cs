using System; 

class URI {

    static void Main(string[] args) { 

        double tempo,velocidade,calculo;
        
        tempo = double.Parse(Console.ReadLine());
        velocidade = double.Parse(Console.ReadLine());
        
        
        calculo = (tempo * velocidade)/12;
        
        Console.WriteLine("{0:f3}",calculo);

    }

}