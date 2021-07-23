using System; 

class minhaClasse{

    static void Main() { 

       int[] carro = new int[50];

       for(int i =0 ; i<10;i++){
           carro[i]=int.Parse(Console.ReadLine());
       }
        for(int i =0 ; i<10;i++){
            Console.WriteLine("{0} ",carro[i]);
       }


    }

}