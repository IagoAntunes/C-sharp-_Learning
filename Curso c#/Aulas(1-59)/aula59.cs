using System;
using System.Collections.Generic;

// Queue
/*
*/


class Aula59{
    static void Main() {
        
        //string[] v = {"Carro","Moto","Navio","Avião"};

        Queue<string>veiculos = new Queue<string>(); //FILA, (v),iniciaria com os elementos
        
        veiculos.Enqueue("Carro");//Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Avião");

        string v = "Avião";
        if(veiculos.Contains(v)){//Confere se o valor existe
            Console.WriteLine("Veiculo "+ v + " Encontrado");
        }else{
            Console.WriteLine("Veiculo "+ v + "Não esta na  fila");     
        }
        //veiculos.Clear();//Limpa os Valores

        //Console.WriteLine("Primeiro Veiculo: {0}",veiculos.Dequeue());//pega o primeiro elemento retorna ele, e remove ele
        //Console.WriteLine("Primeiro Veiculo: {0}",veiculos.Peek());//Retorna o primeiro elemento,mas não remove

        /*foreach(string veic in veiculos){
            Console.WriteLine("Veiculo: {0}",veic);

            //v = veiculos.Dequeue();
            //Console.WriteLine("Veiculo Removido:{0}",v);
        }*/

        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);
        //Console.WriteLine(veiculos[2]);// NÃO PODE FAZER ISSO

        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
        }
        Console.WriteLine("Tamanho Fila: {0}",veiculos.Count);

    }
}

