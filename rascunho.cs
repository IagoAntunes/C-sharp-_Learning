using System; 


public class Jogador{
    public int vida;
    public int idade;
    public string nome;



    public Jogador(string n){
        vida = 100;
        idade = 18;
        nome = n;
    }
    ~Jogador(){
        Console.WriteLine("FIM -->");
    }


}
class URI{

    static void fim(){
        Console.WriteLine("sera ?");
    }


    static void Main() { 
        string nome;

        nome = Console.ReadLine();



        Jogador j1 = new Jogador(nome);
        Jogador j2 = new Jogador("pEDRO");
    

        Console.WriteLine("Nome 1: {0}",j1.nome);
        Console.WriteLine("Nome 2: {0}",j2.nome);
        fim();

    }
}
