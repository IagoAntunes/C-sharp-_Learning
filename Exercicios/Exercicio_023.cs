using System; 

class URI {

    static void Main(string[] args) { 

        int moneyT,money;
        int nota100=0,nota50=0,nota20=0,nota10=0,nota5=0,nota2=0,nota1=0;
        
        moneyT = int.Parse(Console.ReadLine());
        money = moneyT;
        while(money !=0){
            
            if(money % 100 == 0){
                nota100 ++;
                money = money - 100;
            }else if(money % 50 == 0){
                nota50 ++;
                money = money - 50;
            }else if(money % 20 == 0){
                nota20 ++;
                money = money - 20;
            }else if(money % 10 == 0){
                nota10++;
                money = money - 10;
            }else if(money % 2 == 0){
                nota2 ++;
                money = money - 2;
            }else if(money % 1 == 0){
                nota1++;
                money = money - 1;
            }  
        }
            Console.WriteLine("{0}",moneyT);
            Console.WriteLine("{0} nota(s) de R$ 100,00",nota100);
            Console.WriteLine("{0} nota(s) de R$ 50,00",nota50);
            Console.WriteLine("{0} nota(s) de R$ 20,00",nota20);
            Console.WriteLine("{0} nota(s) de R$ 10,00",nota10);
            Console.WriteLine("{0} nota(s) de R$ 5,00",nota5);
            Console.WriteLine("{0} nota(s) de R$ 2,00",nota2);
            Console.WriteLine("{0} nota(s) de R$ 1,00",nota1);
    

    }

}