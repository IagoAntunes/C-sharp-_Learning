using System;
//Operação de Bitwise
class Aula09 {
    static void Main(){
        // Deslocamento para a esquerda vai Dobrar o valor
        // Deslocamento para a direita  vai Diminuir pela metade

        int num = 10,num2=8;

        num = num <<1; // Deslocar para a Esquerda
        Console.WriteLine(num); // É igual a 20

        num2 = num2 >> 1; // Deslocar para Direita
        Console.WriteLine(num2); // é igual a 4

    }
}