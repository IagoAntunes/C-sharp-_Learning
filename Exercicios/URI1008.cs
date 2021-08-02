using System; 

class URI {

    static void Main(string[] args) { 

    int numero,horas;
    float valor,salarioT;
    
    numero = int.Parse(Console.ReadLine());
    horas = int.Parse(Console.ReadLine());
    
    valor = float.Parse(Console.ReadLine());
    
    salarioT = horas * valor;
    
    Console.WriteLine("NUMBER = {0}",numero);
    Console.WriteLine("SALARY = U$ {0:f2}",salarioT);
    
    

    }
}