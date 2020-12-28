using System;
// Private ou Public

class Veiculo{ //CLASSE BASE
    public int rodas;
    public int velMax;
    public bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return "SIM";
        }else{
            return "NÃO";
        }
    }
}

class Carro:Veiculo{   // Base:Derivada        Base herda a derivada
    public string nome;
    public string cor;
    
    public Carro(string nome,string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor=cor;
    }
}


class Aula34{
    static void Main(){
        Carro c1=new Carro("Rapidão","Vermelho");

        Console.WriteLine("Cor...:{0}",c1.cor);
        Console.WriteLine("Nome...:{0}",c1.nome);
        Console.WriteLine("Rodas...:{0}",c1.rodas);
        Console.WriteLine("Vel.Maxima...:{0}",c1.velMax);
        Console.WriteLine("Ligado...:{0}",c1.getLigado());
    }
}