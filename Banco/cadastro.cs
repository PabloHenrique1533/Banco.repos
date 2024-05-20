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
        public bool[] prioritario = new bool[100];
        public string nomeCli;
        public int idCli;
        public bool prioridade;
        public int QTDprioridade;
        public int idadeCli;
        public int proximaPosicao = 0;
       
        
        public void cdClientes()
        {
            
            
                Console.WriteLine("\nDigite o Nome Do Cliente:");
                nomeCli = Console.ReadLine().ToUpper();
                Console.WriteLine("Digite a Idade Do Cliente");
                idadeCli = int.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("De Um ID Para O Cliente");
                idCli = int.Parse(Console.ReadLine().ToUpper());

                Console.WriteLine("O Paciente é Proprietario: S/N:");
                char resposta = Console.ReadLine().ToUpper()[0];

                if(resposta == 'S')
                 {
                  prioridade = true;

                 }else
                 {
                     prioridade = false;
            }

                this.nome[proximaPosicao] = nomeCli;
                this.idade[proximaPosicao] = idadeCli;
                this.id[proximaPosicao] = idCli;
                this.prioritario[proximaPosicao] = prioridade;
         



                if (proximaPosicao >= 10)
                {
                    Console.WriteLine("Não há espaço para mais clientes.");
                    return;
                }
             
                proximaPosicao++;
        }
      

        public void cliFilas()
        {
            
            if(proximaPosicao == 0)
            {
                Console.WriteLine("\nA Fila está vazia");
                return;
            }
            else
            {
                Console.WriteLine("\nClientes na fila:");
                for (int i = 0; i < proximaPosicao; i++)
                {
                    Console.WriteLine($"{i + 1}.{nome[i]}, ID: {id[i]}, Idade: {idade[i]}, Prioritario: {prioritario[i]}    ");
                }
            }
        }

        public void cliPrioritarios()
        {
            if (prioridade == true)
            {

                Console.WriteLine("\n Prioritarios na Fila:");
                for (int i = 0; i < proximaPosicao; i++)
                {
                    if (prioritario[i])
                    {
                        Console.WriteLine($"{i + 1}.{nome[i]}, ID: {id[i]}, Idade: {idade[i]} - Prioritário");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNao ha nenhum prioritario na fila.");
            }
        }
        public void atendeEremoverCli()
        {
               
                    if(proximaPosicao > 0)
                    {
                        bool cliPrioEncontrado = false;
                        int indiceCliePrio = -1;
                        for (int i = 0; i < proximaPosicao; i++)
                        {
                            if (prioritario[i])
                            {
                                indiceCliePrio = i;
                                cliPrioEncontrado |= true;
                                break;
                            }
                            }
                    if (cliPrioEncontrado)
                    {
                        string pessoaAtendida = nome[indiceCliePrio];
                        for (int j = indiceCliePrio + 1; j < proximaPosicao; j++)
                        {
                            nome[j - 1] = nome[j];
                            idade[j - 1] = idade[j];
                            id[j - 1] = id[j];
                        }
                        nome[proximaPosicao - 1] = null;
                        idade[proximaPosicao - 1] = 0;
                        id[proximaPosicao - 1] = 0;
                        proximaPosicao--;

                        Console.WriteLine($"\n Cliente {pessoaAtendida} Foi Removido Da Fila!");
                    }
                    else
                    {
                     string pessoaAtendida = nome[0];

                        for (int j = 1; j < proximaPosicao; j++)
                        {
                            nome[j - 1] = nome[j];
                            idade[j - 1] = idade[j];
                            id[j - 1] = id[j];
                        }

                        nome[proximaPosicao - 1] = null;
                        idade[proximaPosicao - 1] = 0;
                        id[proximaPosicao - 1] = 0;
                        proximaPosicao--;
                        Console.WriteLine($"\n Cliente {pessoaAtendida} Foi Removido Da Fila!");
                    }                 
                }
            else
            {
                Console.WriteLine("\nNao tem ngm pra atender");
            }
                
       
        }
    }
}
