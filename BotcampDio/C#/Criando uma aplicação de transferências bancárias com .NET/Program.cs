using System;
using System.Collections.Generic;

namespace Criandu
{
    class Program
    {
        static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            //ESCOLHAS
            while(opcaoUsuario.ToUpper() != "X"){
                switch(opcaoUsuario){
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utiliar nossos serviços!!");
            Console.WriteLine();
        }
        //METODO TRANSFERIR
        private static void Transferir()
        {
            Console.Write("Digite o numero da Conta:");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.Write("Digite o numero da conta de destino: ");
            double valorTransferencia= double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia,listContas[indiceContaDestino]);
        }

        //METODO DEPOSITAR
        private static void Depositar()
        {
            Console.Write("Digite o numero da Conta:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser Depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }
        //METODO SACAR
        private static void Sacar()
        {
            Console.Write("Digite o numero da Conta:");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor a ser sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorSaque);
        }
        //MOSTRAR CONTAS
        private static void ListarContas()
        {
            Console.WriteLine("Listar Conta");
            if(listContas.Count == 0){
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }
            for(int i = 0;i < listContas.Count;i++){
                Conta conta= listContas[i];
                Console.Write("#{0} - ",i);
                Console.WriteLine(conta);
            }
        }
        //INSERIR
        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            
            Console.Write("Digite 1 para Conta Fisica ou 2 para Juridica");
            int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o Nome do Cliente:");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            double entradaSado = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o credito: ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                                        saldo:entradaSado,
                                        credito:entradaCredito,
                                        nome:entradaNome);

            listContas.Add(novaConta);
        }
        //OPCAO DO USUARIO
        private static string ObterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine("DIO Bank a seu disporr!!");
            Console.WriteLine("Informe a opção desejada!!");

            Console.WriteLine("1. Listar Contas!");
            Console.WriteLine("2. Inserir nova conta");
            Console.WriteLine("3. Transferir");
            Console.WriteLine("4. Sacar");
            Console.WriteLine("5. Depositar");
            Console.WriteLine("6. Limpar Tela");
            Console.WriteLine("X. Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToString();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}