using System; 

class URI {

    static void Main(string[] args) { 

        int qtd=0,aux;
        double coelhos=0,ratos=0,sapos=0,total=0;
        double pcoelhos,pratos,psapos;

        aux = int.Parse(Console.ReadLine());

        for(int i=0;i<aux;i++){
            qtd = 0;
            string[] animals = Console.ReadLine().Split(' ');
            qtd = int.Parse(animals[0]);
            total = total + qtd;
            if(animals[1] == "C"){
                coelhos = coelhos + qtd;;
            }else if(animals[1] == "R"){
                ratos = ratos + qtd;
            }else if(animals[1] == "S"){
                sapos = sapos + qtd;
            }
        }
        pcoelhos = (100 * coelhos)/total;
        pratos = (100 * ratos)/total;
        psapos = (100 * sapos)/total;

        Console.WriteLine("Total: {0} cobaias",total);
        Console.WriteLine("Total de coelhos: {0}",coelhos);
        Console.WriteLine("Total de ratos: {0}",ratos);
        Console.WriteLine("Total de sapos: {0}",sapos);

        Console.WriteLine("Percentual de coelhos: {0:f2} %",pcoelhos);
        Console.WriteLine("Percentual de ratos: {0:f2} %",pratos);
        Console.WriteLine("Percentual de sapos: {0:f2} %",psapos);
    }
}