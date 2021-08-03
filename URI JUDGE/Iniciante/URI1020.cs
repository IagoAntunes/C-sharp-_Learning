using System; 

class URI {

    static void Main(string[] args) { 

        int Idias,anos,mes,dia;
        

        Idias = int.Parse(Console.ReadLine());

        anos = Idias / 365;
        mes = (Idias % 365) / 30;
        dia = ((Idias % 365)%30);
        
        Console.WriteLine("{0} ano(s)",anos);
        Console.WriteLine("{0} mes(es)",mes);
        Console.WriteLine("{0} dia(s)",dia);
        
        

    }
}