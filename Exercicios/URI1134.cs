using System; 

class URI {

    static void Main(string[] args) { 

        int comb;
        int al=0,gas=0,dies=0;

        do{

            comb = int.Parse(Console.ReadLine());
            if(comb == 1){
                al++;
            }else if(comb == 2){
                gas++;

            }else if(comb == 3){
                dies++;
            }else if(comb == 4){
                break;
            }


        }while(comb != 4);

        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: {0}",al);
        Console.WriteLine("Gasolina: {0}",gas);
        Console.WriteLine("Diesel: {0}",dies);


        
    }
}
