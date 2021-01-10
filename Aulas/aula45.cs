using System;
// ARRAY em Struct 
/*
Implementação de ARRAYS COM STRUCT 
*/

struct Carro{

    public string modelo;
    public string cor;

    public void info(){ // Construtor
        Console.WriteLine("Modelo:{0}\nCor:{1}",this.modelo, this.cor);
        Console.WriteLine("---------------------------------------");
    }
}
class Aula45{
    static void Main(){
        //int[] numeros = new int[];
        Carro[] carros=new Carro[4];

        carros[0].modelo = "HRV";
        carros[0].cor = "Prata";

        carros[1].modelo = "Golf";
        carros[1].cor = "Azul";

        carros[2].modelo = "Jetta";
        carros[2].cor = "Branco";

        carros[3].modelo = "Argo";
        carros[3].cor = "Preto";

        for(int i=0;i<carros.Length;i++){
            carros[i].info();
        }

        //carros[0].info;
        //carros[0].info;
        //carros[0].info;
        //carros[0].info;
    }
}

