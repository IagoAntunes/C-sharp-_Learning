using System; 

class URI {
    // URI 1155
    static void Main() { 
        float num = 1;
        float soma=0;
        for(int i =1;i<=100;i++){

            soma = soma + (num/i);

        }
        Console.WriteLine("{0:f2}",soma);
    }
}
