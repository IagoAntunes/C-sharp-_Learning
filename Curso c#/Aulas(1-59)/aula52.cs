using System;
// Exceções - Try Catch Finally 
/*
É um erro , um erro que ocorre na execução do programa
*/

class Aula52{
    static void Main() {

        int n1,n2,res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try{//Se tiver algum erro , vai tratar o erro e entra em Catch
            res = n1/n2;
            Console.WriteLine("{0} / {1} = {2}",n1,n2,res);//Não é executado,se tiver erro no 1
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
            Console.WriteLine("Ex: {0}",e.GetType());
        }

        //Console.WriteLine("{0} / {1} = {2}",n1,n2,res);

 
    }
}

