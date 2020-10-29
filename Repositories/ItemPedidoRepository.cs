using CasaDoCodigo.Models;
using CodigoStore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{

    public interface IItemPedidoRepository
    {
        void UpdateQuantidade(ItemPedido itemPedido);
        ItemPedido GetPedido(int Id);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetPedido(int Id)
        {
            return dbSet.Where(ip => ip.Id == Id).SingleOrDefault();
        }

        public void UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDB = dbSet
                                .Where(ip => ip.Id == itemPedido.Id)
                                   .SingleOrDefault();

            if (itemPedidoDB != null)
            {
                itemPedidoDB.AtualizaQuantidade(itemPedido.Quantidade);
                contexto.SaveChanges();
            }
            
        }
    }
}
