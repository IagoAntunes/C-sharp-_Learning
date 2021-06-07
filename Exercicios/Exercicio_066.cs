using System; 

class URI {

    static void Main() { 

        int qtd=1;
        while(qtd!=0){
           qtd = int.Parse(Console.ReadLine());


           for(int i=1;i<=qtd;i++){
               Console.Write("{0} ",i);
           }
      }
    }
}