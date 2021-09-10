using System;


class pessoaJuridica : Padrao{

    //Obrigatorio
    public override void taxaEmprestimo(Double valor){
        Console.WriteLine("Taxa de Emprestimo R$"+valor * 0.2);
    }




}