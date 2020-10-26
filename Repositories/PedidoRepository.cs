using CasaDoCodigo.Models;
using CodigoStore.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodigoStore.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}
