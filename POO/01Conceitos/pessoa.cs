using System;
//CLASSE - Molde
//

public class pessoa
{
    public string nome; //Tipado
    public int idade;
    //Metodos
    public void Mensagem(){
        Console.WriteLine("Ola " + nome + "Você tem"+idade+"anos");
    }


}