using System; 

class URI {

    static void Main(string[] args) { 

        int inter_gols,gremio_gols;
        int vitoriaI=0,vitoriaG=0,empate=0;
        int qtd=0;
        int opc = 0;

        while(opc != 2){
            string[] vetor = Console.ReadLine().Split(' ');
            inter_gols = int.Parse(vetor[0]);
            gremio_gols = int.Parse(vetor[1]);

            if(inter_gols > gremio_gols){
                vitoriaI ++;
            }else if(gremio_gols > inter_gols){
                vitoriaG ++;
            }else if(gremio_gols == inter_gols){
                empate ++;
            }

            qtd++;
            Console.WriteLine("Novo grenal (1-sim 2-nao)");
            opc = int.Parse(Console.ReadLine());
            if(opc == 2){
                break;
            }
            
        }
        Console.WriteLine("{0} grenais",qtd);
        Console.WriteLine("Inter:{0}",vitoriaI);
        Console.WriteLine("Gremio:{0}",vitoriaG);
        Console.WriteLine("Empates:{0}",empate);
        if(vitoriaG > vitoriaI){
            Console.WriteLine("Gremio venceu mais");
        }else if(vitoriaI > vitoriaG){
            Console.WriteLine("Inter venceu mais");
        }else if(vitoriaG == vitoriaI){
            Console.WriteLine("Nao houve vencedor");
        }
    }
}
