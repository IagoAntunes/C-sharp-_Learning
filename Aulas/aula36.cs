using System;
//PROTECTED

class Veiculo{ // -> BASE
    public int velAtual;
    private int VelMax;
    protected bool ligado;

    public Veiculo(int velMax) {
        velAtual = 0;
        this.VelMax = Velmax;
        ligado = false;
    }
    public int getVelMax(){
        return velMax;
    }
}
class Carro:Veiculo// >- Derivada de Veiculo
{
    public string nome;
    public Carro(string nome,int vm):base(vm) {
        this.nome = nome;
        ligado = true;
    }
    public bool getLigado(){
        return ligado;
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("BMW",120);

        Console.WriteLine("Nome...:{0}",carro.nome);
        Console.WriteLine("Velocidade...:{0}",carro.getVelMax);
        Console.WriteLine("Ligado...:{0}",carro.getligado);
    }
}