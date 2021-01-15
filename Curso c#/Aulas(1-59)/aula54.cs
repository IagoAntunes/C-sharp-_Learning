using System;
// Namespace 
/*
Controlar o Scopo , uma forma de organização
*/

namespace Calc1{ // namespace
    class Area{//CLASSE
        public static float Quad(float bas, float alt){//Metodo
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou Altura não podem ser igual a zero");
            }
            return bas * alt;
        }   
    }
}
namespace Calc2{// namespace
    class Area{//CLASSE
        public static float Quad(float bas, float alt){//Metodo
            if(bas == 0 || alt == 0){
                throw new Exception("Base ou Altura não podem ser igual a zero");
            }
            return bas * alt;
        }
    }
}

class Aula54{
    static void Main() {

        float area=0;

        try{//Se tiver algum erro , vai tratar o erro e entra em Catch
            area = Calc1.Area.Quad(0,5F);
            Console.WriteLine("Area do Quadrado:{0}",area);
            //throw new Exception("ERRO "); // GERANDO UMA EXCEÇÃO
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}",e.Message);
            Console.WriteLine("Ex: {0}",e.GetType());
        }finally{// vai ser executado independentemente se for disparado a EXCEÇÃO
            Console.WriteLine("Fim do Processo!");

        }
    }
}

