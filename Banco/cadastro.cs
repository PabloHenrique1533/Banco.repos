using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class cadastro
    {
        public string[] nome = new string[10] ;
        public int[] id = new int[10];
        public int[] idade = new int[10];
        public string nomeCli;
        public int idCli;
        public int idadeCli;
        public int proximaPosicao = 0;
        public int proximaPosicao2 = 0;
        
        public void cdClientes()
        {
            
            
                Console.WriteLine("Digite o Nome Do Cliente:");
                nomeCli = Console.ReadLine();
                Console.WriteLine("Digite a Idade Do Cliente");
                idadeCli = int.Parse(Console.ReadLine());
                Console.WriteLine("De Um ID Para O Cliente");
                idCli = int.Parse(Console.ReadLine());


                this.nome[proximaPosicao] = nomeCli;
                this.idade[proximaPosicao] =idCli;
                this.id[proximaPosicao] = idCli;



                if (proximaPosicao >= 10)
                {
                    Console.WriteLine("Não há espaço para mais clientes.");
                    return;
                }
             
                proximaPosicao++;
        }
        public void inserirClientes()
        {

            Console.WriteLine("Aperte 2 Para Inserir Os Cliente Cadastrado Na Fila :");
            if(proximaPosicao2 >= 10)
            {
                Console.WriteLine("Nao ha Mais Espaço Para Clientes!!");
                return;
            }

            this.nome[proximaPosicao] = this.nomeCli;
            this.idade[proximaPosicao] = this.idadeCli;
            this.id[proximaPosicao] = this.idCli;

            proximaPosicao2++;
            
        }

        public void cliFilas()
        {
            if(proximaPosicao == 0)
            {
                Console.WriteLine("A Fila está vazia");
                return;
            }
            else
            {
                Console.WriteLine("Clientes na fila:");
                for (int i = 0; i < proximaPosicao; i++)
                {
                    Console.WriteLine($"{i + 1}.{nome[i]}, ID: {id[i]}, Idade: {idade}");
                }
            }
        }

        public void cliPrioritarios()
        {
            
          
        }
    }
}
