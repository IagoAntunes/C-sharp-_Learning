using System;

class Aula20 {

    static void Main(){

        int[] num=new int[10];

        int i=0;
        while(i<num.Length){
            num[i] = int.Parse(Console.ReadLine());
            i++;
        }
        i=0;
        while(i<num.Length){
            Console.WriteLine("Num[{0}] = {1}",i,num[i]);
            i++;
        }
    }
}