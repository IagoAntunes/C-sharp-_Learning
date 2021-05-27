using System; 

class URI {

    static void Main(string[] args) { 

        int n1 =5,n2 = 10;

        soma(n1,n2);
        subtra(n1,n2);
        mult(n1,n2);
        mostrar(n1,n2);

    }
    static void mostrar(int n1,int n2){
        Console.WriteLine("Valor 1 = {0}",n1);
        Console.WriteLine("Valor 2 = {0}",n2);
    }

    static void soma(int n1,int n2){
        Console.WriteLine("Resultado = {0}",n1+n2);
    }
    static void subtra(int n1,int n2){
        Console.WriteLine("Resultado = {0}",n1-n2);
    }
    static void mult(int n1,int n2){
        Console.WriteLine("Resultado = {0}",n1*n2);
    }



}