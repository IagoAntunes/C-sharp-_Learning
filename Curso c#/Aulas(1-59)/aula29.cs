using System;
//Construtores e Destrutores
public class Jogador {

    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n) {//CONSTRUTOR
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador {0} foi destruido",nome);
    }
}

class Aula29 {
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o Nome do Jogador 1");
        nome1 = Console.ReadLine();
        Jogador j1=new Jogador(nome1); // NEW reserva a memoria
        Jogador j2=new Jogador("Theo");

        j1.energia = 50;
        Console.WriteLine("Nome do Jogador 1: {0}",j1.nome);
        Console.WriteLine("Nome do Jogador 2: {0}",j2.nome);
   }
}
