using System;

class Atendente : Imposto{
    public override void valeAlimentacao(Double salario){
        onsole.WriteLine("Desconto Atendente R$"+salario*0.12);
    }
}