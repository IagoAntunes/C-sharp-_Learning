using System; 

class URI {
    // URI 1165
    static void Main() { 
        
       int nTestes;
       int num;
       int ctg;


        nTestes = int.Parse(Console.ReadLine());
        while(nTestes > 0){
           num = int.Parse(Console.ReadLine());
           ctg = 0;
           for(int i =2;i<num;i++){
               if(num % i == 0){
                   ctg++;
               }


           }
           if(ctg > 0){
               Console.WriteLine("{0} nao eh primo",num);
           }else{
               Console.WriteLine("{0} eh primo",num);
           }






            nTestes--;
       }
    }
}
