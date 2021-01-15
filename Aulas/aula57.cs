using System;
using System.Collections.Generic;

// Coleção LinkedList / Lista duplamente encadeada
/*
Onde cada elemento é um nó da lista , que tem um link para o proximo e elemento anterior
*/



class Aula57{
    static void Main() {

        List<string>carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        //carros2.AddRange(carros);//Adicionar valores de carros em carros2
        //carros2.Clear();//Limpa elementos da Lista

    
        if(carros.Contains("Gol")){//Confere se esta na lista
            Console.WriteLine("Esta na Lista");
        }else{
            Console.WriteLine("Não encontrado!");
        }

        carros.CopyTo(carros2,2);//Copiar de Carros2 para carros,apartir da posição 2



        foreach(string c in carros){
            Console.WriteLine("Carro:..{0}",c);
        }

        string ca = "HRV";
        int pos=0;
        pos = carros.IndexOf(ca);// Armazenar posição do C (carro)
        Console.WriteLine("Carro {0} esta na posição {1}",ca,pos);


    }
}

