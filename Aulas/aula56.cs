using System;
using System.Collections.Generic;

// Coleção LinkedList / Lista duplamente encadeada
/*
Onde cada elemento é um nó da lista , que tem um link para o proximo e elemento anterior
*/



class Aula56{
    static void Main() {
        
        LinkedList<string> transp = new LinkedList<string>();//CLASSE da LISTA

        transp.AddFirst("Carro");
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Moto");

        transp.AddLast("Bicicleta");
        
        LinkedListNode<string>no;

        no = transp.FindLast("Navio").Next; //.Next ,.Previous,.Value Aponta para o (proximo,anterior)
        transp.AddAfter(no,"Patinete");

        no = transp.FindLast("Carro");
        transp.AddBefore(no,"Patins");

       // trans.Clear()// remove todos elementos
       if(transp.Find("Carro")==null){
           Console.WriteLine("Não Encontrado");
       }else{
           Console.WriteLine("Elemento Encontrado");
       }

       transp.Remove("Navio");//Remover valor
       transp.RemoveFirst();//Remove o Primeiro Elemento
       transp.RemoveLast();// Remove Ultimo Elemento

        foreach(String t in transp){
            Console.WriteLine("Transporte:..{0}",t);
        }
    }
}

