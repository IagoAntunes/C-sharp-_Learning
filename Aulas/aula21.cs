using System;

class Aula21 {

    static void Main(){

        int num=5;
        /*
            while(num<5){  
                Console.WriteLine("CFB Cursos");
            }
        */
        string senha="1234567";
        string senhauser;
        int tentativas=0;

        

        do{
            Console.Clear();
            Console.WriteLine("Digite a Senha");
            senhauser = Console.ReadLine();
            tentativas++;
        }while(senha != senhauser);
        Console.WriteLine("Logado com Sucesso!\nTentativas:{0}",tentativas);
    }




}