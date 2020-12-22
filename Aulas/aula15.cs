using System;
// Switch Case
class Aula15 {

    static void Main(){
        int tempo=0;
        char escolha;


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
    }
}