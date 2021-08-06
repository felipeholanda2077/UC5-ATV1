using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace UC_5___ATV1
{

    class Program
    {

        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            char fim = 'S';

            do
            {
                Console.Clear();
                Console.WriteLine(" Digite qual o seu produto");
                ItemPedido.produto = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Qual o tipo do produto");
                ItemPedido.descricao = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Qual o valor do pedido ");
                ItemPedido.valor_unitario = Convert.ToDouble(Console.ReadLine());
                
                
                Console.WriteLine(" Quantos pedidos ");
                ItemPedido.quantidade = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Quer adicionar novo PEDIDO? (S/N)");
                int caseSwitch = 1;
                caseSwitch = int.Parse(Console.ReadLine());


                fim = Console.ReadKey().KeyChar;



            }
            while (fim == 'S');
            {
                //apresenta o total do pedido
            }
            }
        }
    }










            