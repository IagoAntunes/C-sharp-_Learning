using System;
//Classes e métodos abstratos
/* 
Uma classe Abstrata é uma classe que serve como base para outras classes que vao herdar uma classe base que voa servir para outras classes derivadas,voce nao pode instanciar uma classe derivada da classe base
Se eu crio metodos q nao sao abstratos eu preciso implementar suas funcionalidades
Se eu crio metodos abstratos eles nao podem ter implementação, eles so servem para dizer q a classe derivada precisa obrigatoriamente implementar um metodo abstrato
*/
abstract class Veiculo{ // Classe Base Abstrata - só pode usar em herança
    protected  int velMaxima;
    protected int velAtual;
    protected int acima;
    protected bool ligado;
    public Veiculo(){ // Construtor;
    // Aqui é a entrada de Valores
        ligado = false; 
        Console.Write("Velocidade Atual:");
        velAtual = int.Parse(Console.ReadLine());
        //velAtual = 0;
    }
    public void setLigado(bool ligado){ 
        this.ligado = ligado;
    }
    public int getVelAtual(){ 
    // Aqui pega o valor de ''VelAtual'' e retorna
        return velAtual;
    }
    abstract public void aceleracao(int mult);

}
class Carro:Veiculo {
    public Carro() { // Construtor
    // Nao usei isso
        velMaxima = 120;
    }
    override public void aceleracao(int mult){
    // Aqui é o calculo para saber a velocidade acima.
        acima = mult - 50;
        //velAtual += 10*mult;
    }
    public int getAcima(){
    // Pega o valor de 'acima' e retorna
        return acima;
    }
}

class Aula39{
    static void Main(){
        Carro carro1 = new Carro(); 
        if(carro1.getVelAtual() > 50){
        //Aqui faço identifico se o carro esta acima da velocidade
            Console.WriteLine("Você esta acima da Velocidade!!!!");
            carro1.aceleracao(carro1.getVelAtual());
        }
        //carro1.aceleracao(1);

        Console.WriteLine("\nVelocidade Atual:{0}\nVelocidade Acima:{1}",carro1.getVelAtual(),carro1.getAcima());

        //Console.WriteLine("Você esta {0} km/h acima da velocidade",carro1.getAcima());
        //Console.WriteLine(carro1.getVelAtual());
        
    }
}