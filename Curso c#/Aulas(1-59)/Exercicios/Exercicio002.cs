/* 
            -------------EXERCICIO002-------------
        Crie um algoritmo que verifique se um número informado é par ou impar
*/

using System;       

class Aula21 {

    static void Main(){

        int num=0;
        int opcao=1;

        do{

        
        Console.Write("Digite um Numero:");
        num = int.Parse(Console.ReadLine());

        if(num % 2 == 0){
            Console.WriteLine("PAR!");
        }else{
            if(num % 2 != 0){
                Console.WriteLine("IMPAR");
            }else{
                Console.WriteLine("Valor Invalido");
            }
        }
        Console.WriteLine("Quer Continuar?[1]Sim [0]Não");
        opcao = int.Parse(Console.ReadLine());
        Console.Clear();
        }while(opcao==1);


    }

}