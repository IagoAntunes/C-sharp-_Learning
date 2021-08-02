using System; 

class URI {
                                //7:08 9:010
    static void Main(string[] args) { 

        int hora=0,minuto=0,aux3,dif=0,dif2=0;
        int initHour,initMinute,finalHour,finalMinute;

        string[] vetor = Console.ReadLine().Split(' ');
        
        initHour = int.Parse(vetor[0]);
        initMinute = int.Parse(vetor[1]);
        finalHour = int.Parse(vetor[2]);
        finalMinute = int.Parse(vetor[3]);

        if(initHour < 25){ 
            if(initHour  == finalHour){
                if(initMinute < finalMinute){
                    hora = 0;
                }else if(initMinute > finalMinute || initMinute == finalMinute){
                    hora = 24;
                }

            }else if(initHour < finalHour){
                hora = finalHour - initHour;
                dif = finalHour - initHour;

            }else if(initHour > finalHour){
                aux3 = 24 - initHour;
                hora = aux3 + finalHour;
            }
            if(initMinute == finalMinute){
                minuto = initMinute - finalMinute;
            }
            else if(finalMinute > initMinute){
                minuto = finalMinute - initMinute;
                
            }else if(initMinute > finalMinute){
                dif2 = initMinute - finalMinute;
                minuto = 60 - dif2;
                if(hora == 0){
                    hora = 0;
                }else{
                    hora = hora - 1;
                }
            }
        }
        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",hora,minuto);
    }
}