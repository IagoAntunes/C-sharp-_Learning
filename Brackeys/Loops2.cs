
using System; 

class minhaClasse{

    static void Main() { 

        //Instancia para Sortear numeros
       Random numberGen = new Random();

       int roll = 0;
       int attempts = 0;

       Console.WriteLine("Press enter to roll the die");

       while(roll != 6){
           Console.ReadKey();

            //Sorteia numeros entre 1 - 7
           roll = numberGen.Next(1,7);
           Console.WriteLine("You rolled: " + roll);
           attempts++;
       }

        Console.WriteLine("It took you "+attempts+" attempts to roll a six");












    }

}