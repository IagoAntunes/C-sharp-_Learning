
using System; 

class minhaClasse{

    static void Main() { 

       Console.WriteLine("How many cool numbers do you want");

        int count = Convert.ToInt32(Console.ReadLine());

        for(int i= 1;i<= count;i++){
            double result = Math.Pow(2,i);
            Console.WriteLine(result);
        }


    }

}