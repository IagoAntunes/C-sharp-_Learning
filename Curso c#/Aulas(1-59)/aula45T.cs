using System;
// ARRAY em Struct 
/*
Implementação de ARRAYS COM STRUCT 
*/

struct Carro{

    public string modelo;
    public string cor;

    public void info(){ // Construtor
        Console.WriteLine("Modelo:{0}\nCor:{1}",this.modelo,this.cor);
        Console.WriteLine("---------------------------------------");
    }
}
class Aula45{
    static void Main(){
        //int[] numeros = new int[];
        Carro[] carros=new Carro[2];
            for(int i =0;i<carros.Length;i++){
                Console.WriteLine("Modelo Carro:");
                carros[i].modelo = Console.ReadLine();
                Console.WriteLine("Cor do Carro");
                carros[i].cor = Console.ReadLine();
            }

        //carros[0].modelo = "HRV";
        //carros[0].cor = "Prata";

        //carros[1].modelo = "Golf";
        //carros[1].cor = "Azul";


        for(int i=0;i<carros.Length;i++) {
            carros[i].info();

        //carros[0].info;
        //carros[0].info;
        //carros[0].info;
        //carros[0].info;
    }
}
}

