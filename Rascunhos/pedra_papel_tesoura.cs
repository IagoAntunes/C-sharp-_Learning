using System; 


class Pessoa{

    public int escolha;
    public string nome;
}

class minhaClasse{

    public static void dueloT(int p1,int p2,string p1Nome,string p2Nome){

        if(p1 == 1 && p2 == 1){
            Console.WriteLine("EMPATE");
        }else if(p1 == 1 && p2 == 2){
            Console.WriteLine("{0} WIN",p1Nome);
        }else if(p1 == 1 && p2 == 3){
            Console.WriteLine("{0} WIN",p1Nome);
        }
        if(p1 == 2 && p2 == 1){
            Console.WriteLine("{0} WIN",p1Nome);
        }else if(p1 == 2 && p2 == 2){
            Console.WriteLine("EMAPTE");
        }else if(p1 == 2 && p2 == 3){
            Console.WriteLine("{0} WIN",p2Nome);
        }
        if(p1 == 3 && p2 == 1){
            Console.WriteLine("{0} WIN",p2Nome);
        }else if(p1 == 3 && p2 == 2){
            Console.WriteLine("{0} WIN",p1Nome);
        }else if(p1 == 3 && p2 == 3){
            Console.WriteLine("EMPATE");
        }
    }

    static void Main() { 

        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();
        int opcao = 0;

        do{
            Console.WriteLine("Jogador 1");
            Console.WriteLine("Nome:");
            p1.nome = Console.ReadLine();
            Console.WriteLine("[1]PEDRA [2]PAPEL [3]TESOURA");
            p1.escolha = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Jogador 2 Escolhe");
            Console.WriteLine("Nome:");
            p2.nome = Console.ReadLine();
            Console.WriteLine("[1]PEDRA [2]PAPEL [3]TESOURA");
            p2.escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0} Escolheu {1}",p1.nome,p1.escolha);
            Console.WriteLine("{0} Escolheu {1}",p2.nome,p2.escolha);

            dueloT(p1.escolha,p2.escolha,p1.nome,p2.nome);

            
            Console.WriteLine("Deseja Continuar ?");
            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

        }while(opcao != 1);
    }
}


//Atirar
//Recarregar +1 bala
//Defender
