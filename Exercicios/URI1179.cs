using System;

class URI {
    // URI 1179
    static void zerar(int[] vetor){
        for(int i =0;i<vetor.Length;i++){
            vetor[i] = 0;
        }
    }
    static void printarP(int[] par){
        for(int i =0;i<5;i++){
            if(par[i] != 0)
            Console.WriteLine("par[{0}] = {1}",i,par[i]);
        }
    }
    static void printarI(int[] impar){
        for(int i =0;i<5;i++){
            if(impar[i] != 0)
            Console.WriteLine("impar[{0}] = {1}",i,impar[i]);
        }
    }
    static void adicionar(int[] vetor,int num){
        int resp = 0;
        int i = 0;
        while(resp != 1){
            if(vetor[i] == 0){
                vetor[i] = num;
                //Console.WriteLine("{0} adicionado",vetor[i]);
                resp = 1;
            }else{
                i ++;
            }
        }
    }

    static void Main() { 
        int[] par = new int[5] {0,0,0,0,0};
        int[] impar = new int[5] {0,0,0,0,0};
        int num;
        int countP=0,countI=0;
        int j=0;
        for(int i =0;i<15;i++){
            num = int.Parse(Console.ReadLine());
            if(num % 2 == 0){
                if(countP == 5){
                    printarP(par);
                    zerar(par);
                    countP = 0;
                    adicionar(par,num);
                    countP ++;
                }else{
                    adicionar(par,num);
                    countP ++;
                }
            }else if(num % 2 != 0){
                if(countI == 5){
                    printarI(impar);
                    zerar(impar);
                    countI = 0;
                    adicionar(impar,num);
                    countI ++;
                }else{
                    adicionar(impar,num);
                    countI ++;
                }
            }
            j++;
        }
        printarI(impar);
        printarP(par);
    }
}
