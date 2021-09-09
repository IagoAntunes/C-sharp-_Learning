using System;


class Pessoa{

    //Metodo01
    public void apresentar(){
        Console.WriteLine("Ola!");
    }

    //Metodo02
    public void apresentar(String nome){
        Console.WriteLine("Ola "+nome);
    }

    //Metodo03
    public void apresentar(String nome , int idade){
        Console.WriteLine("Ola "+nome + " voce tem " + idade + " anos");
    }


}