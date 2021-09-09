using System;

namespace _03ExerciciosE
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.nome = "joao";
            aluno.nota1 = 8;
            aluno.nota2 = 5;


            aluno.mensagem();
        }
    }
}
