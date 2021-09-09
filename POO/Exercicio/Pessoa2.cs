using System;

class Pessoa2{


    private string nome;
    private int idade;
    private int peso;


    public int Idade{
        get{return idade;}
        set{idade = value;}
    }

    public void maioridade(){
        if(Idade > 18){
            Console.WriteLine("MAIOR DE IDADE" + Idade);
        }else if(Idade < 18){
            Console.WriteLine("Menor de idade" + Idade);
        }
    }
}