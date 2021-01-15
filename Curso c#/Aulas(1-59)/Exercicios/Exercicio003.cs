/* 
            -------------EXERCICIO003-------------
        Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.
*/

using System;       

class Aula21 {

    static void Main(){

        int[] idade=new int[10];
        int maior=0;
        int menor=0;

        for(int i=0; i<10; i++){
            Console.Write("Pessoa{0} Idade:",i);
            idade[i] = int.Parse(Console.ReadLine());
            if(idade[i] >=18){
                maior ++;
            }else{
                menor++;
            }
        }

        Console.WriteLine("Maiores de Idade : {0}",maior);
        Console.WriteLine("Menores de Idade: {0}",menor);


    }

}