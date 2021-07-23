using System; 

class minhaClasse{

    static void Main() { 

        // Declara o vetor com tamanho 4
        string[] movies = new string[4];

        Console.WriteLine("Type in four movies:");

        for(int i=0;i<movies.Length;i++){
            movies[i] = Console.ReadLine();
        }

        // Coloca o vetor em ordem alfabetica
        Array.Sort(movies);

        for(int i =0 ;i < movies.Length;i++){
            Console.WriteLine(movies[i]);
        }





    }
}