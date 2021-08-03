using System; 

class URI {

    static void Main(string[] args) { 

        int calculo,km;
    
        km = int.Parse(Console.ReadLine());
        
        calculo = (km * 60) / 30;
        
        Console.WriteLine("{0} minutos",calculo);

    }

}