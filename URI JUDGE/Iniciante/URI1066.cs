using System; 

class URI {

    static void Main() { 

        
        int par=0,impar=0,neg=0,pos=0;
        int[] vetor = new int[5];

        foreach(int x in vetor){
            vetor[x] = Int32.Parse(Console.ReadLine());
            if(vetor[x] % 2 == 0){
                par ++;
            }else{
                impar ++;
            }
            if(vetor[x] > 0){
                pos ++;
            }else if(vetor[x] < 0){
                neg++;
            }
        }
        Console.WriteLine("{0} valor(es) par(es)",par);
        Console.WriteLine("{0} valor(es) impar(es)",impar);
        Console.WriteLine("{0} valor(es) positivo(s)",pos);
        Console.WriteLine("{0} valor(es) negativo(s)",neg);

    }
}