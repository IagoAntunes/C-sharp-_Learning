using System;

class Aluno
{
    private Double nota1;
    private Double nota2;

    private Double media(){
        return (nota1 + nota2)/2;
    }
    public void mensagem(){
        Console.WriteLine("Informe a Primeira nota: ");
        nota1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a Segunda nota: ");
        nota2 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Media = "+media());
    }
}