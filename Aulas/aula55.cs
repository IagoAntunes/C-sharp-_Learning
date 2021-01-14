using System;
using System.Collections.Generic;

// Dictionary
/*

*/

class Aula55{
    static void Main() {

        Dictionary <int,string> veiculos = new Dictionary <int, string>();//CONSTRUTOR
         //tipo de chave, tipo de valor tipo do diction

        veiculos.Add(10,"Carro");
        veiculos.Add(5,"Avião");
        veiculos.Add(0,"Navio");
        veiculos.Add(20,"Moto");
        veiculos.Add(15,"Patinete");

        //veiculos.Clear();

        veiculos.Remove(20);//Remover chave

        int chave = 20;
        Console.WriteLine("Tamanho do Dictionary:{0}",veiculos.Count);
        if(veiculos.ContainsKey(chave)){//METODO(ContainsKey(20))se achar , retorna TRUE
            Console.WriteLine("A chave {0} estan a coleção!",chave);
        }else{
            Console.WriteLine("O valor {0} não esta na coleção",chave);
        }

        veiculos[15] = "Bicileta";

        string valor = "Bicileta";
        if(veiculos.ContainsValue(valor)){
            Console.WriteLine("O valor {0} estan a coleção!",valor);
        }else{
            Console.WriteLine("O valor {0} não esta na coleção",valor);
        }

        Dictionary<int,String>.ValueCollection valores  = veiculos.Values;

        /*foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Value);
        }*/
        foreach(string v in valores){
            Console.WriteLine(v);
        }


    }
}

