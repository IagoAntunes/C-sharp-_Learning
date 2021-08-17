using System;

class Desafio {
    static void Main() {
    //declare suas variaveis corretamente
    int res = 1;
    double nota;
    int count = 0;
    double  media = 0;
    int opc;
        //continue a solução ou implemente da sua maneira
        while ( res != 2) {
            nota = double.Parse(Console.ReadLine());
            if (nota < 0 || nota > 10                  ) {
                Console.WriteLine("nota invalida");
            }else if (nota >=0 && nota <=10   ) {
                count ++;
                media = media + nota;
            } 
            if(count == 2){
                media = media / 2;
                Console.Write("media = ");
                Console.WriteLine(media.ToString("N2"));
                media = 0;
                count = 0;
                opc = 0;
                while(opc != 1){
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    res = int.Parse(Console.ReadLine());
                    if(res == 2){
                        res = 2;
                        opc = 1;
                    }else if(res == 1){
                        opc = 1;
                    }
                }
                
            }

        } 
    }
}
