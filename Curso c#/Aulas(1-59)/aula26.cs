using System;
//Argumento Out
class Aula26 {

    static void Main(){
        int divid=10,divis=2,resto,quoc=divide(divid,divis,out resto);

        Console.WriteLine("{0} / {1} = {2} , resto={3}",divid,divis,quoc,resto);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quociente = dividendo / divisor;//= 5
        resto = dividendo % divisor;// = 0
        return quociente;
    }
}