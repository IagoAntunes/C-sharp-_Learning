using System; 

class URI {
    // URI 1164
    static void Main() { 
        
        int nTestes;
        int soma=0;
        int num;

        nTestes = int.Parse(Console.ReadLine());


        while(nTestes>0){
            num = int.Parse(Console.ReadLine());
            soma = 0;
            for(int i =1;i<num;i++){
                if(num % i ==0){
                    soma = soma + i;
                }
            }
            if(soma == num){
                Console.WriteLine("{0} eh perfeito",num);
            }else{
                Console.WriteLine("{0} nao eh perfeito",num);
            }
            nTestes --;
        }
    }
}
aaaaaaaaaaa
