#include <stdlib.h>
#include <stdio.h>


int main(){

    int N,K,U;


    printf("Numero de Cartelas:");
    scanf("%i",&N);
    printf("Cada cartela tera:");
    scanf("%i",&K);
    printf("Maximo de valores");
    scanf("%i",&U);

    int cartela[N][K];
    int vetor[K];
    int comparar[N];

    for(int i=0;i<N;i++){
        for(int j=0;j<K;j++){
            cartela[i][j] = rand() % U;
        }
    }

    for(int i=0;i<N;i++){
        for(int j=0;j<K;j++){
            printf("  %i  ",cartela[i][j]);
            vetor[i] = rand() % U;
            if(vetor[i] == cartela[i][j]){
                comparar[i]++;
            }
            if(comparar[i] == K){
                printf("Cartela %i campea",i);
            }
        }
        printf("\n");
    }

    for(int i =0;i<K;i++){
        printf(" %i ",vetor[i]);
    }








}
