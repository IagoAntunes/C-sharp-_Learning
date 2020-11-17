using System;

class Aula25 {

    static void Main(){
        int num = 10,num2=10;
        dobrar1(ref num);// ref = REFERENCIA
        dobrar2(num2);

        Console.WriteLine("NUM1 = {0} , NUM2 = {1}",num,num2);

    }
    // Passagem por Referencia
    static void dobrar1(ref int valor){
        valor *=2;
    }
    // Passagem por Valor
    static void dobrar2(int valor){
        valor *=2;
    }
}