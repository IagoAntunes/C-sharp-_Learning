using System;

class Pessoa{

    public Double peso;
    public Double altura;

    public Double imc(){
        return peso/(altura * altura);
    }

    public String calculo(){

        if(imc() < 18.5){
            return "Abaixo do Peso";
        }else if(imc() < 25){
            return "Peso Normal";
        }else if(imc() < 30){
            return ("Acima do Peso");
        }else if(imc() < 35){
            return "obesidade 1";
        }else if(imc() < 40){
            return "obesidade 2";
        }else{
            return "obesidade 3";
        }
    }
    public void mensagem(){
        Console.WriteLine("Ola, seu IMC é "+imc()+"e você se enquadra em"+calculo());
    }
}