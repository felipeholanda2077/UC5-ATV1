using System;
using System.Collections.Generic;

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
                Console.WriteLine("Olá, o que deseja?");
                Console.WriteLine("1 - Listar pedidos");
                Console.WriteLine("2 - Criar pedido");
                Console.WriteLine("3 - Selicionar pedido ");
                Console.WriteLine("4 - Adicionar item ao pedido");
                Console.WriteLine("5 - Finalizar pedido");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Quer adicionar novo PEDIDO? (S/N)");
                fim = Console.ReadKey().KeyChar;

            }
            while (fim == 'S');


            