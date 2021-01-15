using System;
//GET E SET
class Carro{
    //private int velMax;
    private int multa;
    public int vm{// Propriedade
        get{
            return multa;
        }
        set{
            if(value < 0){// Se o valor passado a Propriedade
                //velMax = 0;
                multa =0;
            }else if(value > 60){
                //velMax = 300;
                multa = 80;
            }else{
                //velMax = value;
                multa = 0;
            }
        }
    }
    public Carro(){// Construtor
        //this.velMax=120;
        Console.WriteLine("Velocidade:");
        vm = int.Parse(Console.ReadLine());
        //vm = 120;
    }

    /*public void vm(int velMax){
        this.velMax = velMax;
    }*/
}
class Aula41{
    static void Main(){
        Carro c1=new Carro();
        if(c1.vm == 80){
            Console.WriteLine("Multa = {0}",c1.vm);
        }else{
            Console.WriteLine("Não há multas!");
        }
        
        
    }
}