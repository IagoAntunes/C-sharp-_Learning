using System; 

class minhaClasse{

    static void Main() { 

       Console.WriteLine("Welcome Tickets are 5$ .Insert the cash");

       int cash = Convert.ToInt32(Console.ReadLine());

       if(cash < 5){
           Console.WriteLine("That is not enough money");
       }else if(cash == 5){
           Console.WriteLine("Here is your ticket");
       }else {
           int change = cash - 5;
           Console.WriteLine("Here is your ticket and " + change + " dollars in change" );
       }







    }

}