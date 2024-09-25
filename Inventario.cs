using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE
{
    internal class Inventario
    {
        private List<Item> itens = new List<Item>();

        public int Count => itens.Count;

        public void AdicionarItem(Item item)
        {
            itens.Add(item);
            Console.WriteLine("Item adicionado com sucesso!\n");
        }

        public void ListarItens()
        {
            Console.WriteLine("\n--- Itens no Inventário ---");
            if (itens.Count == 0)
            {
                Console.WriteLine("Nenhum item cadastrado.");
            }
            else
            {
                for (int i = 0; i < itens.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {itens[i]}");
                }
            }
            Console.WriteLine();
        }

        public void EditarItem(int index, Item novoItem)
        {
            if (index >= 0 && index < itens.Count)
            {
                itens[index] = novoItem;
                Console.WriteLine("Item atualizado com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Índice inválido!\n");
            }
        }

        public void RemoverItem(int index)
        {
            if (index >= 0 && index < itens.Count)
            {
                itens.RemoveAt(index);
                Console.WriteLine("Item removido com sucesso!\n");
            }
            else
            {
                Console.WriteLine("Índice inválido!\n");
            }
        }
    }
}
