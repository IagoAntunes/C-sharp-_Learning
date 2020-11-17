using System;

public class Jogador {

    public int energia=100;
    public bool vivo=true;
}

class Aula28 {
    static void Main(){
        Jogador j1=new Jogador(); // NEW reserva a memoria
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

        j1.energia = 50;
        Console.WriteLine("Energia do Jogador 1: {0}",j1.energia);
        Console.WriteLine("Energia do Jogador 1: {0}",j2.energia);
   }
}

/*//------ESBOÇO DA CLASSE MOSTRADA NA AULA:---------------------------------------//

//      [ModificadorClasse] class NOME_DA_CLASSE
//      {
//      Variáveis / Propriedades
//      [EspecificadorAcesso] tipo NOME_PROPRIEDADE;
//      
//      Metodos
//      [EspecificadorAcesso] retorno NOME_METODO([arg1,...])
//      {
//      corpo do método
//      }
// }

//-------O QUE SÃO E APLICAÇÕES:-----------------------------------------------//

//      [ModificadorClasse]: Define a visibilidade da classe.
//      public: pública, sem restrição de visualização.
//      abstract: Classe-Base para outrsas classes, não podem ser instanciados a objetos desta classe
//      sealed: Classe não pode ser herdada
//      static: Classe não permite a instanciação de objetos e seus membros devem ser "static"
//
//      [EspecificadorAcesso]: Onde um membro da classe pode ser acessado
//      public: pública, sem restrição de acesso.
//      private: Só podem ser acessados pela própria classe.
//      protected: Podem ser acessados na própria classe e nas classes derivadas
//      abstract: Os métodos não tem implementação somente os cabeçalhos
//      sealed: O método não pode ser redefinido.
//      virtual: O método pode ser redefinido em uma classe derivada.
//      static: o método pode ser chamado mesmo sem a instanciação de um objeto.
*/