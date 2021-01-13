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
        //return n1 + n2;

    }
    public double soma(params double[]n){//METODO
        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
        return s;
        //return n1 + n2;

    }
    /*
    public int soma(int n1, int n2, int n3){//METODO
        return n1 + n2 + n3;

    }
    public int soma(int n1, int n2, int n3, int n4){//METODO
        return n1 + n2 + n3 + n4;

    }
    */
}


class Aula47{
    static void Main(){
        //double res;
        int qtd;
        double result;
        Console.WriteLine("Tamanho do Vetor:");
        qtd = int.Parse(Console.ReadLine());
        double[] res = new double[qtd];// isso é PARAMS
        
        Calc calc = new Calc();
        
        for(int i=0;i<res.Length;i++){
            Console.WriteLine("Digite um Numero:");
            res[i] = double.Parse(Console.ReadLine());
        }

            
        result = calc.soma(res);
        //res = calc.soma(10,5,3);//Pode-se colocar(passar) 2 , 3 ou 4 valores

        Console.WriteLine("Resultado = {0}",result);

    }
}

