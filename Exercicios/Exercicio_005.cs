/*FATORIAL Recursivo*/

using System; 

    class fatorial{

        static int fat(int n){
            int resp;
            if(n == 1){
                resp = 1;
            }else{
                resp = n * fat(n - 1);
            }
            return resp;
        }
        
        static void Main() { 
            Console.WriteLine("Resposta = {0} ",fat(5));
        }
    }
