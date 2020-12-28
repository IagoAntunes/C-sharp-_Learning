using System;
//FOR
class Aula19 {

    static void Main(){

        int[] num=new int[10];
        int i;
        /*
        for(num=0;num<10;num++){
            Console.WriteLine("Num = {0}",num);
        }
        */
            
        for(i=0;i<num.Length;i++){
            num[i] = int.Parse(Console.ReadLine());
        }
        for(i=0;i<num.Length;i++){
            Console.WriteLine("Num{0} = {1}",i+1,num[i]);
        }
    }
}