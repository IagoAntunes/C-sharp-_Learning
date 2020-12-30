using System;
//Metodo Virtual
class Base{ // -> BASE
    public Base(){
        Console.WriteLine("Construtor da Classe Base");
    }

    virtual public void info(){ // Vou poder declararesse metodo em outra classe , mas ele sera sobreescrito
        Console.WriteLine("Base");
    }
}
class Derivada1:Base{ //
    public Derivada1(){
        Console.WriteLine("Construtor da Classe Derivada1");
    }
    override public void info(){//SOBREESCREVER 
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2:Derivada1{ // 
    public Derivada2(){
        Console.WriteLine("Construtor da Classe Derivada2");
    }
}


class Aula38{
    static void Main(){
        Base Ref;
        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        Ref = derivada1;
        Ref.info();
        //derivada1.info();
        //derivada2.info();
    }
}