using System;
// Exceções - Try Catch Finally 
/*
É um erro , um erro que ocorre na execução do programa
*/

class Area{//CLASSE
    public static float Quad(float bas, float alt){//Metodo
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou Altura não podem ser igual a zero");
        }
        return bas * alt;
    }
}


class Aula53{
    static void Main() {

        float area=0;

        try{//Se tiver algum erro , vai tratar o erro e entra em Catch
            area = Area.Quad(0,5F);
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

