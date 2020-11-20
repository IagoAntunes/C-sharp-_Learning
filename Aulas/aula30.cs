using System;
// Sobrecarga de Construtores
public class Jogador {

    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(){
        energia = 100;;
        vivo = true;
        nome = "Jogador";
    }

        public Jogador(string n){
        energia = 100;;
        vivo = true;
        nome = n;
    }

        public Jogador(string n,int e){
        energia = 100;;
        vivo = true;
        nome = n;
    }
    public Jogador(string n,int e,bool v) {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info(){
        Console.Write(" Nome Jogador:..{0}  \n",nome);
        Console.Write(" Energia Jogador:..{0}  \n",energia);
        Console.Write(" Estado Jogador:..{0}  \n\n",vivo);
    }
}
class Aula29 {
    static void Main(){

        Jogador j1=new Jogador(); // NEW reserva a memoria
        Jogador j2=new Jogador("Bruno");
        Jogador j3=new Jogador("Théo",100);
        Jogador j4=new Jogador("Benegundes",0,false);

        j1.info();
        j2.info();
        j3.info();
        j4.info();
   }
}
