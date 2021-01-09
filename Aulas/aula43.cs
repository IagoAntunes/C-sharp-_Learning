using System;
//INTERFACE
/*As interfaces só implementam METODOS ou PROTOTIPOS DO METODOS
nao se usa campos na interface,toda classe que implementar a interface tem que implementar
seus metodos, uma classe pode Herdar mais de 1 interface :)  */

public interface Veiculo{
    //int numero; INTERFACE NAO PODE CONTER CAMPOS
    void ligar(); //assinatura do METODO
    void desligar();// METODO
    void info(); //  METODO
}
public interface Combate{

    void disparar(); // METODO
}
class Carro:Veiculo,Combate{ // PRECISA IMPLEMENTAR OS MEMBROS 
    public bool ligado; //MEMBRO
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }
    public void ligar(){ //IMPLEMENTAR MEMBROS / METODOS
        this.ligado = true;
    }
    public void desligar(){//IMPLEMENTAR MEMBROS / METODOS
        this.ligado = false;
    }
    public void disparar(){ // Implementar metodo do (COMBATE)

    }
    public void info(){//IMPLEMENTAR MEMBROS / METODOS
    
    }
}
class Aula43{
    static void Main(){
        Carro c1=new Carro();
        
    }
}

