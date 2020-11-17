using System;

class Aula26 {

    static void Main(){
        double saldo = 100.0;
        double valorDoSaque = 10.0;
        saldo = saldo - valorDoSaque;

        MessageBox.Show("O saldo da conta após o saque é: " + saldo);
    }


}