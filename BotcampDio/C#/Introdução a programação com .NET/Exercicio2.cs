using System; 

class minhaClasse {

    static void Main(string[] args) { 

            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste ; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if((v1.Equals("tesoura") && v2.Equals("papel")) 
                    || (v1.Equals("papel") && v2.Equals("pedra")) //complete a solução
                    || (v1.Equals("lagarto") && v2.Equals("Spock")) 
                    || (v1.Equals("Spock")  && v2.Equals("tesoura"))
                    || (v1.Equals("tesoura") && v2.Equals("lagarto")) 
                    || (v1.Equals("lagarto") && v2.Equals("papel"))
                    || (v1.Equals("papel") && v2.Equals("Spock")) 
                    || (v1.Equals("Spock") && v2.Equals("pedra"))
                    || (v1.Equals("pedra") && v2.Equals("tesoura")) 
                    || (v1.Equals("pedra") && v2.Equals("lagarto")))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);                
                else if (v1.Equals(v2))   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

    }

}