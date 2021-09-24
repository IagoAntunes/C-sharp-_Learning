using System;

class Trabalhador : Empresa{
    public int matricula{get;set;}
    public string nome{get;set;}
    public double salario{get;set;}
    //Trabalhador
    public Trabalhador(int matricula,string nome,double salario){
        this.matricula = matricula;
        this.nome = nome;
        this.salario = salario;
    }
    public void aumento(){
        if(gstotalProdutos > 50){
            Salario = ((Salario * 10)/100) + Salario;
        }
    }
}