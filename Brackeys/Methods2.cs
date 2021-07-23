using System;
using System.Collections.Generic;

class minhaClasse{

    static void Main() { 

       int result = Multiply(3,3);
       Console.WriteLine("The result is " + result);

       if(result % 2 == 0){
           Console.WriteLine(result + " is an even number");
       }else{
           Console.WriteLine(result + " is an uneven number!");
       }
    }

    static int Multiply(int num01,int num02){
        int result = num01 * num02;
        return result;
    }









}