using System;

class Aula16 {

    static void Main(){
        int tempo=0;
        char escolha;

        inicio:

        Console.Clear();

        Console.WriteLine("Belo Horizonte/MG á Vitoria/ES");
        Console.WriteLine("Escolha o Transporte:\n[a]Avião\n[c]Carro\n[o]Onibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo=50;
                break;
            case 'c':
            case 'C':
                tempo=480;
                break;
            case 'o':
            case 'O':
                tempo=660;
                break;
            default:
                tempo = -1;
                Console.Write("Ha algo de errado :(\n");
                break;
        }

        if(tempo <0){
            Console.WriteLine("Transporte Indisponivel");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é {0} minutos",tempo);
        }
        Console.WriteLine("Calcular outro Transporte ?[s/n]");
        escolha = char.Parse(Console.ReadLine());
        if(escolha=='s' || escolha == 'S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("Fim do Programa");
        }
    }
}