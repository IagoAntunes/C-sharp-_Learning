using System; 

class minhaClasse {

    static void Main(string[] args) { 

        string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if( v.Length <= 140 ) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");

    }

}