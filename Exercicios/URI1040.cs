using System; 

class URI {

    static void Main(string[] args) { 

        double media=0,media2=0,notaE=0,N1,N2,N3,N4;

        string[] vetor = Console.ReadLine().Split(' ');
        
        N1 = double.Parse(vetor[0]);
        N2 = double.Parse(vetor[1]);
        N3 = double.Parse(vetor[2]);
        N4 = double.Parse(vetor[3]);

        N1 = N1 * 2;
        N2 = N2 * 3;
        N3 = N3 * 4;
        N4 = N4 * 1;



        media = (N1 + N2 + N3 + N4)/10;
        Console.WriteLine("Media: {0:f1}",media);
        
        if(media >= 7.0){
            Console.WriteLine("Aluno aprovado.");
        }else if(media < 5.0){
            Console.WriteLine("Aluno reprovado.");
        }else if(media < 6.9){
            Console.WriteLine("Aluno em exame.");
            notaE = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota do exame: {0}",notaE);
            media2 = (notaE + media)/2;
            if(media2 >= 5.0){
                Console.WriteLine("Aluno aprovado.");
            }else if(media2 <= 4.9){
                Console.WriteLine("Aluno reprovado.");
        }
        Console.WriteLine("Media final: {0:f1}",media2);
        }

    
    }
}