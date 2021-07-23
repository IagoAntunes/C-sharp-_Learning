using System;
using System.Collections.Generic;

class minhaClasse{

    static void Main() { 

        // Listas - Não precisa colocar o tamanho
       List<string> shoppingList = new List<string>();

        //Adicionando valores na Listta
       shoppingList.Add("Dreams");
       shoppingList.Add("Miracles");
       shoppingList.Add("Rainbows");
       shoppingList.Add("Pony");

       for(int i = 0;i<shoppingList.Count;i++){
           Console.WriteLine(shoppingList[i]);
       }

        //Removedo valores na lista VALOR,INDICE
        shoppingList.Remove("Dreans");
        shoppingList.RemoveAt(1);

        Console.WriteLine("--------");

        for(int i =0;i<shoppingList.Count;i++){
            Console.WriteLine(shoppingList[i]);
        }


    }
}