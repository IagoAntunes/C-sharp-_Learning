using System;
//Sobrecarga de Construtores
static public class Jogador {
    static public int energia;
    static public bool vivo;
    static public string nome;

    static public void iniciar(string n){
        energia = 100;;
        vivo = true;
        nome = n;
    }

    static public void info(){
        Console.Write(" Nome Jogador:..{0}  \n",nome);
        Console.Write(" Energia Jogador:..{0}  \n",energia);
        Console.Write(" Estado Jogador:..{0}  \n\n",vivo);
    }
}
class Inimigo{
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    public void info(){
        Console.WriteLine("Nome:{0}",nome);
        Console.WriteLine("Alera:{0}",alerta);
        Console.WriteLine("------------");
    }
}

class Aula31 {
    static void Main(){
        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo i1= new Inimigo("Doido");
        Inimigo i2= new Inimigo("Maluco");
        Inimigo i3= new Inimigo("Pirado");

        Inimigo.alerta=true;
        i1.info();
        i2.info();
        i3.info();
   }
}
