using System;


abstract class Padrao
{

    //Obrigatorio
    public abstract void taxaEmprestimo(Double valor);

    //Opcional  
    public void calculoPoupanca(Double valor,Double taxa){
        Console.WriteLine("Ganhos obtidos:R$"+valor*taxa);
    }


}