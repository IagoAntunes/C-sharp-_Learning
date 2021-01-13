using System;
// DELEGATES
/*
É um objeto que pode fazer referencia a metodo(quantos metodos quiser dentro da classe)
pode ter uma classe com varios metodos static , com um DELEGATE que vai fazer referencia a todos metodos dessa classe.
*/

delegate int Op(int n1, int n2);//DELEGATE
class Mat{

    public static int soma(int n1, int n2){//metodo
        return n1 + n2;
    }
    public static int mult(int n1, int n2){//Metodo
        return n1 * n2;
    }
}

class Aula50{
    static void Main(){

        int res;

        Op d1 = new Op(Mat.soma);//Passar o metodo para fazer referencia
        res = d1(10,50);

        Console.WriteLine("Soma:{0}", res);
        
        d1 = new Op(Mat.mult);
        res = d1(10,50);

        Console.WriteLine("Multiplicação: {0}",res);


    }
}

