using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao Banco do Jef! \n " +
                "\nEscolha Oque Você Deseja Fazer com as Opções Abaixo:");

           
            cadastro id1 = new cadastro();
            char opcao ='0'; 
            while(opcao != 'q')
            {
                Console.WriteLine("\n1. Cadastrar Clientes/Inserir Clientes Na Fila \n" +
                   "2.Mostra Clientes Na Fila Atuais  \n" +
                   "3.Clientes Prioritarios  \n" +
                   "4.Atender Clientes(retirar clientes da fila)  \n" +
                   "q. Para Sair Do Sistema!");

                opcao = Console.ReadKey().KeyChar;
                switch (opcao)
                {
                    case '1':
                        
                        id1.cdClientes();
                    break;

                    case '2':
                        id1.cliFilas();
                    break;

                    case '3':
                        id1.cliPrioritarios();
                    break;

                    case '4':
                        id1.atendeEremoverCli();
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
