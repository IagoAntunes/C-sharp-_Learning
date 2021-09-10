using System;


class Imposto{
    public virtual void valeAlimentacao(Double salario){
        Console.WriteLine("Desconto Padrao R$"+salario*0.1);
    }
    public virtual void valeTransporte(Double salario){
        Console.WriteLine("Desconto Padrao R$"+salario*0.06);
    }
}