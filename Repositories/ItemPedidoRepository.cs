using CasaDoCodigo.Models;
using CodigoStore.Context;
using CodigoStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{

    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int ItemPedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int Id)
        {
            var Item =  dbSet.Where(ip => ip.Id == Id).FirstOrDefault();
            
            return Item;
        }

    }
}
