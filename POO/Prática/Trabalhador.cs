using System;

class Trabalhador : Empresa{
    private int matricula;
    private string nome;
    private double salario;


    public Trabalhador(int matricula,string nome,double salario){
        this.matricula = matricula;
        this.nome = nome;
        this.salario = salario;
    }
    public double Salario{
        get{return salario;}
        set{salario = value;}
    }
    public string Nome{
        get{return nome;}
        set{nome = value;}
    }
    public int Matricula{
        get{return matricula;}
        set{matricula = value;}
    }
    public void aumento(){
        if(gstotalProdutos > 50){
            Salario = ((Salario * 10)/100) + Salario;
        }
        
    }








}