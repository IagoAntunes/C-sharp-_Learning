using System;
//Classe Sealed
sealed class Veiculo{ // Sealed não pode ser herdada

}
//sealed abstract class Veiculo{} Não pode usar ABSTRACT com SEALED E STATIC

//class Carro:Veiculo{} // Não pode acontecer


class Aula40{
    static void Main(){
        Carro c1 = new Carro();
        
    }
}


/*   Utilização de SEALED  e ABSTRACT juntos       --Nao sei se pode--
abstract MateriaPrima{}
sealed ProdutoFinal:MateriaPrima{}
*/