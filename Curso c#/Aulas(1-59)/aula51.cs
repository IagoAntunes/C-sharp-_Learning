using System;
// Argumentos de entrada do programa
/*

*/

class Aula51{
    static void Main(string[] args) {

        int res = 0;

        if(args.Length > 0) {
            Console.WriteLine("Quantidade:{0}",args.Length);
            for(int i=0;i<args.Length;i++){
                //Console.WriteLine("Argumento{0} = {1}",i+1,args[i]);
                res += Int32.Parse(args[i]);
            }
            Console.WriteLine("Soma:{0}",res);
        }else{
            Console.WriteLine("Não foram passaods argumentos!! ");
        }

        //Console.WriteLine("CFB Cursos");
 
    }
}

