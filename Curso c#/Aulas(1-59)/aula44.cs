using System;
//Struct 
/*
Quando se define uma estrutura , estou falando que é um tipo que vai permitir o armazenamento de dados de diferentes tipos de dados,
Membros da STRUCT são acessados diretamente
Não pode-se HERDAR STRUCT 
*/

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca,string modelo,string cor){//Construtor
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void info(){ // Construtor
        Console.WriteLine("Marca:{0}\nModelo:{1}\nCor:{2}",this.marca, this.modelo, this.cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1=new Carro("Honda","HRV","Azul");

        //c1.marca = "VW";
        //c1.modelo = "golf";
        //c1.cor = "branco";

        c1.info();
        //Console.WriteLine("Marca:{0}\nModelo:{1}\nCor:{2}".c1.marca, c1.modelo, c1.cor);
    }
}

