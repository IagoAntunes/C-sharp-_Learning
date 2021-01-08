using System;
//GET E SET
class Carro{
    private int velMax;
    public int vm{// Propriedade
        get{
            return velMax;
        }
        set{
            if(value < 0){// Se o valor passado a Propriedade
                velMax = 0;
            }else if(value > 300){
                velMax = 300;
            }else{
                velMax = value;
            }
        }
    }
    public Carro(){// Construtor
        //this.velMax=120;
        vm = 120;
    }

    /*public void vm(int velMax){
        this.velMax = velMax;
    }*/
}
class Aula41{
    static void Main(){
        Carro c1=new Carro();

        c1.vm = 200;
        Console.WriteLine("Velocidade:{0}",c1.vm);
        
    }
}
