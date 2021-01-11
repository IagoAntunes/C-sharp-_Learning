using System;
// Sobrecarga de Métodos
/*

*/

class Calc{
    //Metodos podem ter o mesmo nome,se tiverem listas de parametros diferentes
    public int soma(params int[]n){//METODO
        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;

    }
    public double soma(params double[]n){//METODO
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
    }

    public int fat(int n){
        int res;
        if(n<=1){
            res =1;
        }else{
            res = n* fat(n-1);
        }
        return res;
    }

}


class Aula48{
    static void Main(){
        //double res;
        Calc calc = new Calc();
        var res = calc.fat(5);
        Console.WriteLine(res);

    }
}

