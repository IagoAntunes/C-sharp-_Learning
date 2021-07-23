using System; 

class minhaClasse{

    static void Main() { 

       
        string[] movies = new string[4];

        Console.WriteLine("Type in four movies:");

        for(int i=0;i<movies.Length;i++){
            movies[i] = Console.ReadLine();
        }


        Array.Sort(movies);

        for(int i =0 ;i < movies.Length;i++){
            Console.WriteLine(movies[i]);
        }





    }
}