
using System; 

class minhaClasse{

    static void Main() { 

       int age;
       int height;

       Console.Write("Please input age: ");
       age = Convert.ToInt32(Console.ReadLine());

       Console.Write("Please input Height (cm): ");
       height = Convert.ToInt32(Console.ReadLine());

       if(age >= 18 && height >= 160){
           Console.WriteLine("You can enter");
       }else{
           Console.WriteLine("You don't meet the requirements.");
       }





    }

}