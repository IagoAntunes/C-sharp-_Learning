using System;
//Indexadores de Classes
/* Indexador é um meMbro de uma classe que vai permitir aos objetos da classe 
serem indexados como se fossem arrays*/

class Carro{
    private int[] velMax=new int[5]{80,120,160,240,300};
    public int this[int i]{
        get{
            return velMax[i];
        }
        set{
            if(value < 0){// Se o valor passado a Propriedade
                velMax[i] = 0;
            }else if(value > 300){
                velMax[i] = 300;
            }else{
                velMax[i] = value;
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
class Aula42{
    static void Main(){
        Carro c1=new Carro();

        c1[4] = 200;// Objeto sendo usado como ARRAY
        Console.WriteLine("Velocidade:{0}",c1[4]);
        
    }
}

// INDEXADOR PERMITE QUE O OBJETO SEJA USADO COMO ARRAY