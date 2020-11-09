using System;

class Aula25 {

    static void Main(){
        int num = 10;
        dobrar1(ref num);// ref = REFERENCIA

        Console.WriteLine(num);

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