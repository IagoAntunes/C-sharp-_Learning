using System; 

class URI {

    static void Main(string[] args) { 

       int senha = 2002;

       int tentativa,opc = 0;

        while(opc != 1){
            tentativa = int.Parse(Console.ReadLine());
            if(tentativa == senha){
                Console.WriteLine("Acesso Permitido");
                opc = 1;
            }else{
                Console.WriteLine("Senha Invalida");
            }
        }
    }
}
