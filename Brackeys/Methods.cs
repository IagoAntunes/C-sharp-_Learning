using System;
using System.Collections.Generic;

class minhaClasse{

    static void Main() { 
        MeetAlien();
        Console.WriteLine("---------");
        MeetAlien();
    }
    static void MeetAlien(){

        Random numberGen = new Random();

        string name = "X-" + numberGen.Next(10,9999);
        int age = numberGen.Next(10,500);

        Console.WriteLine("HI , I'm " + name);
        Console.WriteLine("I'm " + age + " years Old");
        Console.WriteLine("Oh, and I'am an alien");

    }
}