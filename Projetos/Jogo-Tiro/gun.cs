using System; 


//Classe com atributos de cada jogador
class Pessoa{

    public int vida;
    public int balas;
    public int escudo;

    public int getbalas(){
        return balas;
    }
    //Atributos com valores padrao;
    public Pessoa(){
        vida = 1;
        balas = 1;
        escudo = 0;
    }
    //Metodo Atirar
    public int Atirar(){
        balas = getbalas();
        if(balas > 0){
            balas --;
        }else{
            Console.WriteLine("Você não tem bala!!!");
        }
        return balas;
    }

    //Metodo Recarregar
    public int Recarregar(){
        balas = getbalas();
        balas = balas + 1;
        return balas;
    }
    //Metodo Usar Escudo
    public int useEscudo(){
        escudo = escudo + 1;
        return escudo;
    }

    //Mostrar quantidade de Balas
    public void printStatus(){
        Console.WriteLine("Balas: {0} ",balas);
    }

}

class minhaClasse{

    static void Main() { 

        //Instancias
    Pessoa pessoa1 = new Pessoa();
    Pessoa pessoa2 = new Pessoa();

    int p1;
    int p2;
    int situacao=0;

    do{
        Console.WriteLine("Jogada do Player 1");
        Console.WriteLine("[1]-Atira [2]-Reccarega [3]-Escudo");
        p1 = int.Parse(Console.ReadLine());

        pessoa1.printStatus();

        Console.WriteLine("------------------------------------");

        Console.WriteLine("Jogada do Player 2: ");
        Console.WriteLine("[1]-Atira [2]-Reccarega [3]-Escudo");
        p2 = int.Parse(Console.ReadLine());
        pessoa2.printStatus();

        if(p1 == 1){
            pessoa1.Atirar();
        }else if(p1 == 2){
            pessoa1.Recarregar();
        }else if(p1 == 3){
            pessoa1.useEscudo();
        }
        

        if(p2 == 1){
            pessoa2.Atirar();
        }else if(p2 == 2){
            pessoa2.Recarregar();
        }else if(p2 == 3){
            pessoa2.useEscudo();
        }
        
        Console.Clear();
        if(p1 == 1 && p2 == 1){
            Console.WriteLine("Os dois Morreram...");
            situacao = 1;
        }else if(p1 == 1 && p2 == 2){
            Console.WriteLine("Jogador 2 Morreu");
            situacao = 1;
        }else if(p1 == 1 && p2 == 3){
            Console.WriteLine("Tiro bloqueado");
            situacao = 0;
        }else if(p2 == 1 && p1 == 2){
            Console.WriteLine("Jogador 1 Morreu");
            situacao = 1;
        }else if(p2 == 1 && p1 == 3){
            Console.WriteLine("Tiro Bloqueado");
            situacao = 0;
        }else if(p1 == 2 && p1 == 2){
            Console.WriteLine("2 jogadores Recarregando");
            situacao = 0;
        }else if(p1 == 3 && p2 == 3){
            Console.WriteLine("2 jogadores Usaram Escudo");
            situacao = 0;
        }
        



    }while(situacao != 1);
    }
}


//Atirar
//Recarregar +1 bala
//Defender
