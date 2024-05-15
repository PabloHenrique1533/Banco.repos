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
                "Escolha Oque Você Deseja Fazer com as Opções Abaixo:");

           
            cadastro id1 = new cadastro();
            char opcao ='0'; 
            while(opcao != 'q')
            {
                Console.WriteLine("1. Cadastrar Clientes \n" +
                   "2. Inserir Clientes Na Fila \n" +
                   "3. Mostra Clientes Na Fila Atuais \n" +
                   "4. Clientes Prioritarios \n" +
                   "5. Atender Clientes(retirar clientes da fila) \n" +
                   "q. Para Sair Do Sistema!");

                opcao = Console.ReadKey().KeyChar;
                switch (opcao)
                {
                    case '1':
                        
                        id1.cdClientes();
                    break;

                    case '2':
                        id1.inserirClientes();
                    break;

                    case '3':
                        id1.cliFilas();
                    break;
                }
                
            }
            Console.ReadKey();
        }
    }
}
