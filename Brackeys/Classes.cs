using System;
using System.Collections.Generic;


class wizard{
    public string name;
    public string favoriteSpell;
    private int spellSlots;
    private float experience;
    public static int Count;


    public wizard(string _name,string _favoriteSpell){
        name = _name;
        favoriteSpell = _favoriteSpell;
        spellSlots = 2;
        experience = 0f;
        Count++;
    }
    public void CastSpell(){
        if(spellSlots > 0){
            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
            experience += 0.3f;
        }else{
            Console.WriteLine(name + " is out of spell slots");
        
    }
    }
    public void Meditate(){
        Console.WriteLine(name + " medidates to regain spell slots");
        spellSlots = 2;
    }
}


class minhaClasse{

    static void Main() { 

       wizard wizard001 = new wizard("Parry Hopper","Unexpecto Patronum");
       wizard001.CastSpell();
       wizard wizard002 = new wizard("Jose ", "Bola de Fogo");

       wizard002.CastSpell();

       Console.WriteLine(wizard.Count);


    }
}