using System; 

class URI {
    // URI 1158
    static void Main() { 
        
        int T;
        int PA,PB;
        int anos=0;
        int aumento1,aumento2;
    
        decimal G1,G2;
        int j=0;

        T = int.Parse(Console.ReadLine());// CASOS DE TESTE
        
        
        
        while(j<T){
            anos = 0;
            string[] vetor = Console.ReadLine().Split(' ');
            PA = int.Parse(vetor[0]);//POPULAÇÃO DE A
            PB= int.Parse(vetor[1]);// POPULAÇÃO DE B
            G1 = decimal.Parse(vetor[2]);//Crescimento Populacional
            G2 = decimal.Parse(vetor[3]);//Crescimento Populacional
            int PA2=PA,PB2=PB;
            while(PA2 <= PB2){

                //Console.WriteLine("{0} * {1} = {2}",PA,G1,(PA * G1)/100);
                PA2 = PA2 + (int)Math.Round((PA2 * G1)/100);
                PB2 = PB2 + (int)Math.Round((PB2 * G2)/100);
                //Console.WriteLine("PA2 = {0}\nPB2={1}",PA2,PB2);
                anos++;

                if(anos > 100){
                    break;
                }

            }
            if(anos > 100){
                Console.WriteLine("Mais de 1 seculo.");
            }else{
                Console.WriteLine("{0} anos.",anos);
            }
            
            j++;
        }
    }
}
