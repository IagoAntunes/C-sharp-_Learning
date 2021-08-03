using System; 

class URI {

    static void Main(string[] args) { 

        int tempo,horas,minutos,segundos;
        
        tempo = int.Parse(Console.ReadLine());

        horas = (tempo / 3600);
        minutos = ((tempo % 3600) / 60);
        segundos = (tempo % 60);
        
        Console.WriteLine("{0}:{1}:{2}",horas,minutos,segundos);
        
        

    }

}