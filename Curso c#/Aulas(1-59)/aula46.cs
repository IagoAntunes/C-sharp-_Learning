using System;
// Métodos que retornam objetos
/*

*/

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public int total;

    public Galinha(string nomeGalinha){//Metodo(precisa dos parametros),Construtor
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar(){ //Metodo para retornar objeto OVO
        numOvo++;
        total += numOvo;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;

    public Ovo(int numOvo,string minhaGalinha){//Metodo(precisa dos parametros),Construtor
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("-=-Ovo Criado:{0}\n{1}",this.numOvo,this.minhaGalinha);


    }
}

class Aula46{
    static void Main(){
        Galinha g1 = new Galinha("Atroox");
        Galinha g2 = new Galinha("Fizz");
        Galinha g3 = new Galinha("Ashe");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();

        Console.WriteLine("Total de Ovos:{0}",g1.total);
    }
}

