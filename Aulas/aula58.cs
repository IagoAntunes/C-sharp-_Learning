using System;
using System.Collections.Generic;

// Coleção List P1
/*
*/


class Aula58{
    static void Main() {

        List<string>carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        //carros2.AddRange(carros);//Adicionar valores de carros em carros2
        //carros2.Clear();//Limpa elementos da Lista

    
        if(carros.Contains("Gol")){//Confere se esta na lista
            Console.WriteLine("Esta na Lista");
        }else{
            Console.WriteLine("Não encontrado!");
        }

        carros.CopyTo(carros2,2);//Copiar de Carros2 para carros,apartir da posição 2

        carros.Insert(1,"Cruze");//Inserir em uma determinada posição

        int pos2 = carros.LastIndexOf("HRV");//Pesquisar o ultimo HRV na lsita(repetido)

        //carros.Remove("Argo");//remover elemento
        //carros.RemoveAt(
            
        carros.Reverse();//Inverter a LISTA
        carros.Sort();//Ordena a LISTA

        int tamanho = carros.Count;//Pegar tamanho da lista(preenchidos)
        carros.Capacity = 15;//Muda a CAPACIDADE da lista
        int capa = carros.Capacity;//Capacidade de elementos q pode armazenar


        Console.WriteLine("Tamanho:{0}",tamanho);
        Console.WriteLine("Tamanho:{0}",capa);


        foreach(string c in carros){
            Console.WriteLine("Carro:..{0}",c);
        }

        string ca = "HRV";
        int pos=0;
        pos = carros.IndexOf(ca);// Armazenar posição do C (carro)
        Console.WriteLine("Carro {0} esta na posição {1}",ca,pos);
        Console.WriteLine("Ultimo HRV esta na posição {0}",pos2);
    }
}

