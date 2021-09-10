using System;


class pessoaFisica : Padrao{

    //Obrigatorio
    public override void taxaEmprestimo(Double valor){
        Console.WriteLine("Taxa de Emprestimo R$"+valor * 0.1);
    }




}