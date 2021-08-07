using System;
using System.Collections.Generic;

namespace UC_5___ATV1
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            List<Pedido> pedidos = new List<Pedido>();
            ItemPedido Item = new ItemPedido();
            char fim = 'S';

            do
            {
                Console.Clear();
                Console.WriteLine(" Digite qual o seu produto");
                ItemPedido.produto = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Qual o tipo do produto");
                Item.descricao = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine(" Qual o valor do pedido ");
                Item.valor_unitario = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine(" Quantos pedidos ");
                Item.quantidade = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Quer adicionar novo PEDIDO? (S/N)");
                fim = Console.ReadKey().KeyChar;

                int caseSwitch = 1;
                caseSwitch = int.Parse(Console.ReadLine());

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("Case 1");
                        break;

                    case 2:
                        Console.WriteLine("Case 2");
                        break;

                    default:
                        Console.WriteLine("ERRO");
                        break;
                }

                //apresenta o total do pedido

            } while (fim == 'S') ;
        }
    }
}








