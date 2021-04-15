using System; 

class URI {

    static void Main(string[] args) { 

        string opcao1,opcao2,opcao3;

        opcao1 = Console.ReadLine();
        if(opcao1 == "vertebrado"){
            opcao2 = Console.ReadLine();
            if(opcao2 == "ave"){
                opcao3 = Console.ReadLine();
                if(opcao3 == "carnivoro"){
                    Console.WriteLine("aguia");
                }else if(opcao3 == "onivoro"){
                    Console.WriteLine("pomva");
                }
            }else if(opcao2 == "mamifero"){
                opcao3 = Console.ReadLine();
                if(opcao3 == "onivoro"){
                    Console.WriteLine("homem");
                }else if(opcao3 == "herbivoro"){
                    Console.WriteLine("vaca");
                }
            }
        }else if(opcao1 == "invertebrado"){
            opcao2 = Console.ReadLine();
            if(opcao2 == "inseto"){
                opcao3 = Console.ReadLine();
                if(opcao3 == "hematofago"){
                    Console.WriteLine("pulga");
                }else if(opcao3 == "herbivoro"){
                    Console.WriteLine("lagarta");
                }
            }else if(opcao2 == "anelideo"){
                opcao3 = Console.ReadLine();
                if(opcao3 == "hematofago"){
                    Console.WriteLine("sanguessuga");
                }else if(opcao3 == "onivoro"){
                    Console.WriteLine("minhoca");
                }
            }
        }
    }
}