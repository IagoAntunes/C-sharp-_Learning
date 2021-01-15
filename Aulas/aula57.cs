using System;
using System.Collections.Generic;

// Coleção LinkedList / Lista duplamente encadeada
/*
Onde cada elemento é um nó da lista , que tem um link para o proximo e elemento anterior
*/



class Aula57{
    static void Main() {
        
        LinkedList<string> transp = new LinkedList<string>();//CLASSE da LISTA

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        foreach(String t in transp){
            Console.WriteLine("Transporte:..{0}",t);
        }
    }
}

