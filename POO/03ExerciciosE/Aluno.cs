using System;
class Aluno{
    //Atributos
    public string nome;
    public Double nota1, nota2;
    public Double media(){
        return (nota1 + nota2)/2;
    }
    public String situacao(Double media){
        return media>=7 ?"aprovado":"reprovado";
    }
    public void mensagem(){
        //double obterMedia = media();
        //string obterSituacao = situacao(obterMedia);
        Console.WriteLine(nome+" esta "+situacao(media())+" com media "+media());
    }
}