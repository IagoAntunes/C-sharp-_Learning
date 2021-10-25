using System;
//CLASSE - Molde
//

public class pessoa
{
    public string nome; //Tipado
    public int idade;
    //Metodos
    public String Mensagem(){
        return "Ola " + nome + "Você tem"+idade+"anos";
        //Console.WriteLine("Ola " + nome + "Você tem"+idade+"anos");
    }
}