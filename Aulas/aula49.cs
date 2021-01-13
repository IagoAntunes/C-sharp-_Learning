using System;
// Métodos e Variáveis estáticos (static)
/*
Tenho uma classe e quero utilizar os metodos dessa classe sem ter que declarar o objeto dessa classe, entao nao preciso declarar a classe como STATIC só seus membros 
*/

class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){// METODO
        return n * 2;
    }
}

class Aula49{
    static void Main(){
        // Não precisa declarar um objeto MAT 
        double vpi = Mat.pi;
        int num =10;
        
        //mat m1 = new Mat();

        Console.WriteLine("Pi = {vpi}");
        Console.WriteLine("Dobro = {0}",Mat.dobro(num));
    }
}

