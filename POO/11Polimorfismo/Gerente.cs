using System;

class Gerente : Imposto {

    public override void valeAlimentacao(Double salario){
        Console.WriteLine("Desconto Gerente R$"+salario*0.15);
    }

}