using System; 

class URI {

    static void Main(string[] args) {

        float qtd = 0;
        float soma=0,nota;

        while(qtd < 2){
            nota = float.Parse(Console.ReadLine());

           if(nota >= 0 && nota <= 10 ){
               soma = soma + nota;
               qtd ++;
           }else{
               Console.WriteLine("nota invalida");
           }
           nota = 0;
        }
        Console.WriteLine("media = {0}",soma/2);
    }
}